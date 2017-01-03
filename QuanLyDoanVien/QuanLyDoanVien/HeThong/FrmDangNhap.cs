using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDoanVien.TienIch;
using QuanLyDoanVien.DuLieu;
using System.IO;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace QuanLyDoanVien.HeThong
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        bool isFirstRun = false;
        const string MSG_NOT_VALIDATE = "Không hợp lệ";
        public FrmDangNhap()
        {
            InitializeComponent();

            NapGhiNho();
            // Tìm xem có phải là lần chạy đầu tiên không?
            object tmp;
            Param.GetValue("Lần chạy đầu tiên", out tmp, ParamCategory.System, true, DataType.Bool);
            isFirstRun = (bool)tmp;
        }
        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            LuuGhiNho(chkDuyTriDangNhap.Checked);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                LuuGhiNho(chkDuyTriDangNhap.Checked);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool CheckLogin(string user, string pass)
        {
            // Tìm trong CSDL xem có User nào trùng với tên đăng nhập không?
            NguoiDung userLogin = XpoDefault.Session.FindObject<NguoiDung>(CriteriaOperator.Parse("[TaiKhoan] = ?", user));

            // Nếu có thì kiểm tra mật khẩu đúng không?
            if (userLogin != null)
            {
                if (userLogin.CheckUserPassword(pass))
                {
                    if (userLogin.HoatDong)
                    {
                        clsDuLieu.NguoiDungDangNhap = userLogin;
                        return true;
                    }
                    else
                    {
                        MsgBox.ShowWarningDialog("Tài khoản của bạn đang bị khóa.\nVui lòng liên hệ quản trị để biết chi tiết!");
                        return false;
                    }
                }
                else
                {
                    // Sai mật khẩu
                    txtMatKhau.ErrorText = MSG_NOT_VALIDATE;
                }
                return false;
            }

            // Hiện tại trong CSDL chưa có user nào, ta có thể xem đây là lần chạy đầu tiên (đối với khách hàng)
            // Ta cần tạo ra 1 user có quyền cao nhất (admin), vì chưa làm phân quyền nên chỉ cần tạo 1 user
            // Sau này thêm thông số để biết đây có phải là lần chạy đầu tiên hay k?

            // Giờ sửa lại code isFirstRun luôn
            if (userLogin == null && isFirstRun) // Đoạn code này sẽ không chạy nữa nếu không phải lần chạy đầu
            {
                if (MsgBox.ShowYesNoDialog(string.Format("Đây là lần chạy đầu tiên, bạn có muốn tạo tài khoản [{0}] với quyền [quản trị]? ", user)) == DialogResult.No) return false;

                userLogin = new NguoiDung(XpoDefault.Session);
                userLogin.TaiKhoan = user;
                userLogin.SetPassword(pass);
                var nhom = new NhomNguoiDung(XpoDefault.Session) { TenNhom = "Quản trị", QuanTri = true };
                nhom.Save();
                userLogin.Nhom = nhom;
                userLogin.QuanTri = true;
                userLogin.Save();

                clsDuLieu.NguoiDungDangNhap = userLogin;

                // Cấu hình và khởi tạo dữ liệu khi sử dụng lần đầu
                string xls_donvihanhchinh = Application.StartupPath + @"\Resources\Don_Vi_Hanh_Chinh_2016.xls";
                ImportData.ImportHanhChinhList(xls_donvihanhchinh, "Tỉnh", (int)CapHanhChinh.Tinh);
                ImportData.ImportHanhChinhList(xls_donvihanhchinh, "Huyện", (int)CapHanhChinh.Huyen);
                ImportData.ImportHanhChinhList(xls_donvihanhchinh, "Xã", (int)CapHanhChinh.Xa);

                object tmp;
                string str = string.Empty;
                Param.GetValue("Phiên bản Microsoft Office", out tmp, ParamCategory.UserConfig, "Phiên bản 2003", DataType.String);

                str = string.Format(@"{0}\Downloads", Application.StartupPath);
                if (!Directory.Exists(str)) Directory.CreateDirectory(str);
                Param.GetValue("Thư mục lưu tải về", out tmp, ParamCategory.UserConfig, str, DataType.String);

                str = string.Format(@"{0}\Templates", Application.StartupPath);
                if (!Directory.Exists(str)) Directory.CreateDirectory(str);
                Param.GetValue("Thư mục lưu mẫu thiết kế", out tmp, ParamCategory.UserConfig, str, DataType.String);

                str = string.Format(@"{0}\Documents", Application.StartupPath);
                if (!Directory.Exists(str)) Directory.CreateDirectory(str);
                Param.GetValue("Thư mục lưu văn bản đi/đến", out tmp, ParamCategory.UserConfig, str, DataType.String);

                Param.GetValue("Khởi động cùng Windows", out tmp, ParamCategory.System, false, DataType.Bool);
                Param.GetValue("Tạo mã bằng chữ in hoa", out tmp, ParamCategory.UserConfig, false, DataType.Bool);

                clsDuLieu.TaoDuLieuMacDinh();

                // Cập nhật lại isFirstRun = false;
                Param.SetValue("Lần chạy đầu tiên", false);
                return true;
            }
            if (userLogin == null)
            {
                txtMatKhau.ErrorText = MSG_NOT_VALIDATE;
            }

            return false;
        }
        private void NapGhiNho()
        {
            chkDuyTriDangNhap.Checked = Convert.ToBoolean(AppConfig.GetValue("RememberLogin"));
            txtTaiKhoan.Text = AppConfig.GetValue("UserName");
            txtMatKhau.Text = AppConfig.GetValue("UserPassword");
        }
        private void LuuGhiNho(bool remember)
        {
            AppConfig.SetValue("RememberLogin", Convert.ToString(chkDuyTriDangNhap.Checked));
            if (remember)
            {
                AppConfig.SetValue("UserName", txtTaiKhoan.Text.Trim());
                AppConfig.SetValue("UserPassword", txtMatKhau.Text.Trim());
            }
            else
            {
                AppConfig.SetValue("UserName", string.Empty);
                AppConfig.SetValue("UserPassword", string.Empty);
            }
        }
        private void txtTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }
        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }
        private void hplQuenMatKhau_Click(object sender, EventArgs e)
        {
            var f = new FrmQuenMatKhau();
            f.ShowDialog();
        }
    }
}