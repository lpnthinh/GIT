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
    public partial class FrmKyLuatDialog : FrmBaseDialog
    {
        KyLuat _kyluat;
        public FrmKyLuatDialog(KyLuat kyluat)
        {
            InitializeComponent();

            _kyluat = kyluat;
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();

            Text = _kyluat.IsNewObject ? "Thêm kỷ luật" : "Cập nhật kỷ luật";
            if (_kyluat.IsNewObject)
            {
                _kyluat.NgayKyLuat = DateTime.Today;
            }

            UOW = _kyluat.Session as UnitOfWork;
            xpcKyLuat.Session = xpcNhanSu.Session = xpcDonVi.Session = xpcHinhThucKyLuat.Session = UOW;
            xpcNhanSu.Filter = CriteriaOperator.Parse("[DonVi.Id] = ? and [HoatDong] = ? and [NienKhoa.Id] = ?", 
                                                        DonViSLK.EditValue, true, clsHeThong.NienKhoaSuDung.Id);

            DonViSLK.DataBindings.Clear();
            NhanSuSLK.DataBindings.Clear();
            HinhThucKyLuatSLK.DataBindings.Clear();
            NoiDungKyLuatMemoEdit.DataBindings.Clear();
            NgayKyLuatDateEdit.DataBindings.Clear();

            DonViSLK.DataBindings.Add("EditValue", _kyluat, "NhanSu.DonVi!Key");
            NhanSuSLK.DataBindings.Add("EditValue", _kyluat, "NhanSu!Key");
            HinhThucKyLuatSLK.DataBindings.Add("EditValue", _kyluat, "HinhThucKyLuat!Key");
            NoiDungKyLuatMemoEdit.DataBindings.Add("EditValue", _kyluat, "NoiDungKyLuat");
            NgayKyLuatDateEdit.DataBindings.Add("EditValue", _kyluat, "NgayKyLuat");

            dxError.DataSource = _kyluat;
            DonViSLK.Properties.ReadOnly = NhanSuSLK.Properties.ReadOnly = !_kyluat.IsNewObject;
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
                _kyluat = new KyLuat(UOW);
                OnNap();
            }
        }
        protected override void OnXoa()
        {
            _kyluat.Delete();
            OnLuu();
        }
        private void DonViSLK_EditValueChanged(object sender, EventArgs e)
        {
            xpcNhanSu.Filter = CriteriaOperator.Parse("[DonVi.Id] = ? and [HoatDong] = ? and [NienKhoa.Id] = ?",
                                            DonViSLK.EditValue, true, clsHeThong.NienKhoaSuDung.Id);
        }
        private void HinhThucKyLuatSLK_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            var f = new FrmHinhThucKyLuatThem();
            if (f.ShowDialog() == DialogResult.OK)
            {
                xpcHinhThucKyLuat.Reload();
                e.NewValue = f.Id;
            }
        }
        private void HinhThucKyLuatSLK_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcHinhThucKyLuat.Reload();
        }
    }
}