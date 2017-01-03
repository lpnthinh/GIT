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
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using QuanLyDoanVien.DanhMuc;

namespace QuanLyDoanVien.NghiepVu
{
    public partial class FrmKhenThuongDialog : FrmBaseDialog
    {
        KhenThuong _khenthuong;
        public FrmKhenThuongDialog(KhenThuong khenthuong)
        {
            InitializeComponent();

            _khenthuong = khenthuong;
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();

            Text = _khenthuong.IsNewObject ? "Thêm khen thưởng" : "Cập nhật khen thưởng";
            if (_khenthuong.IsNewObject)
            {
                _khenthuong.NgayKhenThuong = DateTime.Today;
            }

            UOW = _khenthuong.Session as UnitOfWork;
            xpcKhenThuong.Session = xpcNhanSu.Session = xpcDonVi.Session = xpcHinhThucKhenThuong.Session = UOW;
            xpcNhanSu.Filter = CriteriaOperator.Parse("[DonVi.Id] = ? and [HoatDong] = ? and [NienKhoa.Id] = ?", 
                                                        DonViSLK.EditValue, true, clsHeThong.NienKhoaSuDung.Id);

            DonViSLK.DataBindings.Clear();
            NhanSuSLK.DataBindings.Clear();
            HinhThucKhenThuongSLK.DataBindings.Clear();
            NoiDungKhenThuongMemoEdit.DataBindings.Clear();
            NgayKhenThuongDateEdit.DataBindings.Clear();

            DonViSLK.DataBindings.Add("EditValue", _khenthuong, "NhanSu.DonVi!Key");
            NhanSuSLK.DataBindings.Add("EditValue", _khenthuong, "NhanSu!Key");
            HinhThucKhenThuongSLK.DataBindings.Add("EditValue", _khenthuong, "HinhThucKhenThuong!Key");
            NoiDungKhenThuongMemoEdit.DataBindings.Add("EditValue", _khenthuong, "NoiDungKhenThuong");
            NgayKhenThuongDateEdit.DataBindings.Add("EditValue", _khenthuong, "NgayKhenThuong");

            dxError.DataSource = _khenthuong;
            DonViSLK.Properties.ReadOnly = NhanSuSLK.Properties.ReadOnly = !_khenthuong.IsNewObject;
        }
        bool Luu()
        {
            dataLayoutControl1.Validate();
            if (dxError.HasErrors) return false;

            return base.OnLuu();
        }
        protected override bool OnLuu()
        {
            if (Luu()) DialogResult = DialogResult.OK;
            return true;
        }
        private void btnLuuVaThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Luu())
            {
                _khenthuong = new KhenThuong(UOW);
                OnNap();
            }
        }
        protected override void OnXoa()
        {
            _khenthuong.Delete();
            OnLuu();
        }
        private void DonViSLK_EditValueChanged(object sender, EventArgs e)
        {
            xpcNhanSu.Filter = CriteriaOperator.Parse("[DonVi.Id] = ? and [HoatDong] = ? and [NienKhoa.Id] = ?",
                                            DonViSLK.EditValue, true, clsHeThong.NienKhoaSuDung.Id);
        }
        private void HinhThucKhenThuongSLK_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            var f = new FrmHinhThucKhenThuongThem();
            if (f.ShowDialog() == DialogResult.OK)
            {
                xpcHinhThucKhenThuong.Reload();
                e.NewValue = f.Id;
            }
        }
        private void HinhThucKhenThuongSLK_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcHinhThucKhenThuong.Reload();
        }
    }
}