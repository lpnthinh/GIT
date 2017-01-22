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
using Lpnt.QuanLyKyThi.DuLieu;
using Lpnt.QuanLy.Ctr;

namespace Lpnt.QuanLy.Frm
{
    public partial class FrmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            TaoMaXacNhan();
        }
        void TaoMaXacNhan()
        {
            bteMaXacNhan.ResetText();

            object tmp;
            Param.GetValue("Tạo mã bằng chữ in hoa", out tmp);
            bteMaXacNhan.Text = Generate.Random((bool)tmp);
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!bteNhapMa.Text.Trim().Equals(bteMaXacNhan.Text))
            {
                MsgBox.ShowWarningDialog("Mã xác nhận không chính xác!");
                return;
            }

            NguoiDung nguoidung = NguoiDung.FindObject<NguoiDung>("EmailLienHe", txtEmailLienHe.Text.Trim());
            if (nguoidung == null)
            {
                MsgBox.ShowWarningDialog(string.Format("Email [{0}] không tồn tại trên hệ thống!", nguoidung.EmailLienHe));
                return;
            }

            string subject = string.Format("Cấp lại mật khẩu - [{0}]", Application.ProductName);
            string body = string.Format("Tên đăng nhập: {0}\n", nguoidung.TenDangNhap);
            body += string.Format("Họ và tên: {0}\n", nguoidung.HoVaTen);
            body += string.Format("Mật khẩu: {0}\n", nguoidung.GetPasswordDecrypt(nguoidung.MatKhau));
            body += "---------------------------------\n";
            body += "Thư tự động gửi từ chương trình, vui lòng không trả lời.\nCảm ơn.";

            if (SendEmail.Send(subject, body))
            {
                MsgBox.ShowSuccessfulDialog("Mật khẩu đã được chương trình gửi về hộp thư của bạn!");
                TaoMaXacNhan();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bteMaXacNhan_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            TaoMaXacNhan();
        }
        private void bteNhapMa_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            bteNhapMa.ResetText();
        }
    }
}