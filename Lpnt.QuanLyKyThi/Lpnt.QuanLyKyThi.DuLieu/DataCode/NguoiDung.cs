using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class NguoiDung
    {
        public NguoiDung(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            fMatKhau = string.Empty;
            fHoatDong = true;
            fQuanTri = false;
        }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);

            switch (propertyName)
            {
                case "TenDangNhap":
                    if (string.IsNullOrEmpty(TenDangNhap))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên đăng nhập không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, TenDangNhap))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên đăng nhập không được trùng";
                    }
                    break;

                case "MatKhau":
                    if (string.IsNullOrEmpty(MatKhau))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mật khẩu không được trống";
                    }
                    break;
            }
        }
        public const string KEY_SECURITY = "lpnt.it";
        public bool CheckUserPassword(string pass)
        {
            //string p = MD5Encoding(pass);
            string p = Encrypt(pass, true, KEY_SECURITY);
            return p.Equals(MatKhau);
        }
        public void SetPassword(string pass)
        {
            // Mã hóa mật khẩu MD5
            //MatKhau = MD5Encoding(pass);
            MatKhau = Encrypt(pass, true, KEY_SECURITY);
        }
        public string GetPasswordDecrypt(string passEncrypt)
        {
            return Decrypt(passEncrypt, true, KEY_SECURITY);
        }
        public string Encrypt(string toEncrypt, bool useHashing, string key)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
            }
            else keyArray = Encoding.UTF8.GetBytes(key);
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public string Decrypt(string toDecrypt, bool useHashing, string key)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
            }
            else keyArray = Encoding.UTF8.GetBytes(key);
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }
        public string MD5Encoding(string Data)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bdrr = System.Text.Encoding.UTF8.GetBytes(Data);
            byte[] barr = md5.ComputeHash(bdrr);
            return Convert.ToBase64String(barr);
        }
    }

}
