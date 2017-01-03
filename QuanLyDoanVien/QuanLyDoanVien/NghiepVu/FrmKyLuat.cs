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

namespace QuanLyDoanVien.NghiepVu
{
    public partial class FrmKyLuat : FrmBase
    {
        public FrmKyLuat()
        {
            InitializeComponent();
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();
            if (clsHeThong.NienKhoaSuDung != null)
                xpc.Filter = CriteriaOperator.Parse("[NhanSu.NienKhoa.Id] = ?", clsHeThong.NienKhoaSuDung.Id);
            xpc.Reload();
        }
        protected override void OnThem()
        {
            var f = new FrmKyLuatDialog(new KyLuat(UOW));
            f.ShowDialog();
            OnNap();
        }
        protected override void OnSua()
        {
            var kyluat = gridViewCustom1.GetFocusedRow() as KyLuat;
            if (kyluat == null) return;

            var f = new FrmKyLuatDialog(kyluat);
            f.ShowDialog();
            OnNap();
        }
        protected override void OnXoa()
        {
            if (gridViewCustom1.SelectedRowsCount == 0) return;

            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) dòng đang chọn?", gridViewCustom1.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gridViewCustom1.DeleteSelectedRows();
            OnLuu();
        }
        private void gridViewCustom1_DoubleClick(object sender, EventArgs e)
        {
            OnSua();
        }
    }
}