using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public partial class NienKhoa
    {
        public NienKhoa(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "Ten":
                    if (string.IsNullOrEmpty(Ten))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, Ten))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên không được trùng";
                    }
                    break;
            }
        }
        public static void KhoiTao()
        {
            NienKhoa obj = new NienKhoa(XpoDefault.Session) { Ten = "2016-2017", SuDung = true };
            obj.Save();

            obj = new NienKhoa(XpoDefault.Session) { Ten = "2017-2018", SuDung = false };
            obj.Save();

            obj = new NienKhoa(XpoDefault.Session) { Ten = "2018-2019", SuDung = false };
            obj.Save();

            obj = new NienKhoa(XpoDefault.Session) { Ten = "2019-2020", SuDung = false };
            obj.Save();
        }
    }

}
