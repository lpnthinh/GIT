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
using QuanLyDoanVien.DuLieu;
using QuanLyDoanVien.TienIch;

namespace QuanLyDoanVien.HeThong
{
    public partial class FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        NguoiDung _nguoidung;
        bool _isNew;
        public FrmNguoiDung(NguoiDung nguoidung)
        {
            InitializeComponent();

            _nguoidung = nguoidung;
            _isNew = nguoidung.IsNewObject;
            Text = _isNew ? "Thêm người dùng mới" : string.Format("Cập nhật người dùng: {0}", _nguoidung.TaiKhoan);

            layoutControlItem5.Visibility = _isNew == true ?
                    DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            this.Height = _isNew == true ? this.Height - layoutControlItem5.Height : this.Height;
            txtTaiKhoan.Properties.ReadOnly = !_isNew;
            txtMatKhauMoi.Enabled = txtXacNhanMatKhau.Enabled = _isNew;
            txtTaiKhoan.DataBindings.Add("EditValue", _nguoidung, "TaiKhoan");
            txtHoVaTen.DataBindings.Add("EditValue", _nguoidung, "HoVaTen");
            txtDienThoai.DataBindings.Add("EditValue", _nguoidung, "DienThoai");
            txtEmailLienHe.DataBindings.Add("EditValue", _nguoidung, "EmailLienHe");

            dxErrorProvider1.DataSource = _nguoidung;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!_isNew && !_nguoidung.CheckUserPassword(txtMatKhau.Text))
            {
                txtMatKhau.ErrorText = "Mật khẩu không đúng";
                return;
            }

            if (_isNew && string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                txtMatKhauMoi.ErrorText = "Mật khẩu mới không được rỗng";
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                txtXacNhanMatKhau.ErrorText = "Mật khẩu không khớp";
                return;
            }

            _nguoidung.SetPassword(string.IsNullOrEmpty(txtMatKhauMoi.Text) ? txtMatKhau.Text : txtMatKhauMoi.Text);
            try
            {
                if (dxErrorProvider1.HasErrors) return;
                _nguoidung.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.Enabled = txtXacNhanMatKhau.Enabled = _nguoidung.CheckUserPassword(txtMatKhau.Text);
        }
    }
}