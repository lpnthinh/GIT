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
using DevExpress.Data.Filtering;
using QuanLyDoanVien.DuLieu;
using System.IO;
using System.Diagnostics;
using QuanLyDoanVien.DanhMuc;

namespace QuanLyDoanVien.NghiepVu.QLVanBan
{
    public partial class FrmVanBan : FrmBase
    {
        public FrmVanBan()
        {
            InitializeComponent();
            
            ricbKieu.Items.AddEnum(typeof(KieuVanBan), true);
            KieuImageComboBoxEdit.Properties.Items.AddEnum(typeof(KieuVanBan), true);
            if (ricbKieu.Items.Count > 0) icbKieu.EditValue = 0;

            chkHienTuyChonLocDuLieu.EditValue = gvVanBan.OptionsView.ShowFilterPanelMode == DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never ? false : true;
            chkHienKhungTimKiem.EditValue = gvVanBan.OptionsFind.AlwaysVisible;

            dxErrorProvider1.DataSource = xpcVanBan;
            dxErrorProvider1.UpdateBinding();
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();
            xpcVanBan.Reload();
            xpcLoaiVanBan.Reload();
            foreach (VanBan vanban in xpcVanBan)
            {
                vanban.Reload();
                vanban.TepVanBans.Reload();
            }
            xpcVanBan.Criteria = CriteriaOperator.Parse("[Kieu] = ?", icbKieu.EditValue);
        }
        protected override void OnThem()
        {
            gvVanBan.AddNewRow();

            dxErrorProvider1.UpdateBinding();
        }
        protected override void OnXoa()
        {
            if (gvVanBan.SelectedRowsCount == 0) return;
            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) văn bản đang chọn?", gvVanBan.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gvVanBan.DeleteSelectedRows();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            dataLayoutControl1.Validate();

            gvTepVanBan.CloseEditor();
            gvTepVanBan.UpdateCurrentRow();

            if (dxErrorProvider1.HasErrors) return false;
            if (gvVanBan.HasError()) return false;
            if (gvTepVanBan.HasError()) return false;

            if (base.OnLuu()) xpcVanBan.Reload();
            return true;
        }
        private void ricbKieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = sender as ImageComboBoxEdit;
            if (r == null) return;

            xpcVanBan.Criteria = CriteriaOperator.Parse("[Kieu] = ?", icbKieu.EditValue);
        }
        private void gvVanBan_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var vanban = gvVanBan.GetFocusedRow() as VanBan;
            if (vanban == null) return;

            vanban.NgayBanHanh = vanban.NgayHieuLuc = DateTime.Today;
            if (icbKieu.EditValue != null)
                vanban.Kieu = (int)icbKieu.EditValue;
        }
        private void gvTepVanBan_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            var vanban = gvVanBan.GetFocusedRow() as VanBan;
            if (vanban == null) return;

            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                popupMenu1.ShowPopup(Control.MousePosition);

                var tepvb = gvTepVanBan.GetFocusedRow() as TepVanBan;
                if (tepvb == null) return;

                btnMoTep.Enabled = File.Exists(tepvb.DuongDanTep);
            }
        }
        private void ThemSuaTepVanBan()
        {
            var tepvb = gvTepVanBan.GetFocusedRow() as TepVanBan;
            if (tepvb == null) return;

            var op = new OpenFileDialog() { Filter = "All files (*.*)|*.*" };
            if (op.ShowDialog() == DialogResult.OK) tepvb.DuongDanTep = op.FileName;
        }
        private void btnThemTep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvTepVanBan.AddNewRow();
            ThemSuaTepVanBan();
        }
        private void btnSuaTep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemSuaTepVanBan();
        }
        private void btnXoaTep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvTepVanBan.SelectedRowsCount == 0) return;

            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) dòng đang chọn?", gvTepVanBan.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gvTepVanBan.DeleteSelectedRows();
            OnLuu();
        }
        private void btnMoTep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tepvb = gvTepVanBan.GetFocusedRow() as TepVanBan;
            if (tepvb == null) return;

            if (!File.Exists(tepvb.DuongDanTep)) return;

            Process.Start(tepvb.DuongDanTep);
        }
        private void LoaiVanBanSLK_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            var f = new FrmLoaiVanBanThem();
            if (f.ShowDialog() == DialogResult.OK)
            {
                xpcLoaiVanBan.Reload();
                e.NewValue = f.Id;
            }
        }
        private void LoaiVanBanSLK_QueryPopUp(object sender, CancelEventArgs e)
        {
            xpcLoaiVanBan.Reload();
        }
        private void rchkGomNhomDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            var r = sender as CheckEdit;
            if (r == null) return;

            colNamThangBanHanh.GroupIndex = r.Checked ? 0 : -1;
        }
        private void rchkHienKhungTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            var r = sender as CheckEdit;
            if (r == null) return;

            gvVanBan.OptionsFind.AlwaysVisible = r.Checked;
        }
        private void rchkHienTuyChonLocDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            var r = sender as CheckEdit;
            if (r == null) return;

            gvVanBan.OptionsView.ShowFilterPanelMode = r.Checked ? 
                                                        DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways : 
                                                        DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
        }

        private void btnThongKeVanBanTheoLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MsgBox.OpenDialog<FrmThongKeVanBanTheoLoai>();
        }

        private void btnThongKeTheoNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThongKeSoLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MsgBox.OpenDialog<FrmThongKeSoLuong>();
        }
    }
}