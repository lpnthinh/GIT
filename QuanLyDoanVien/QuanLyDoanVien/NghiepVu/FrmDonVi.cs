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
using DevExpress.Skins;
using DevExpress.Data.Filtering;

namespace QuanLyDoanVien.NghiepVu
{
    public partial class FrmDonVi : FrmBase
    {
        public FrmDonVi()
        {
            InitializeComponent();

            Skin skin = GridSkins.GetSkin(treeList1.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            ricbCapDonVi.Items.AddEnum(typeof(CapDonVi), true);
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();
            xpc.Reload();

            treeList1.ExpandAll();
        }
        protected override void OnThem()
        {
            treeList1.Refresh();
            treeList1.AppendNode(null, null);
        }
        private void btnThemCapDuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            treeList1.Refresh();
            var nodeFocus = treeList1.FocusedNode;
            if (nodeFocus == null) return;

            treeList1.AppendNode(null, nodeFocus);
        }
        protected override void OnXoa()
        {
            if (treeList1.FocusedNode == null) return;
            if (treeList1.FocusedNode.HasChildren)
            {
                MsgBox.ShowWarningDialog("Không thể xóa vì có đơn vị cấp dưới!");
                return;
            }

            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa đơn vị đang chọn?", treeList1.Selection.Count));
            if (res == DialogResult.No) return;

            //var donvi = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as DonVi;
            //if (donvi.NhanSus.Count > 0)
            //{
            //    var res = MsgBox.ShowYesNoDialog(string.Format("Hiện đang có ({0}) hồ sơ thuộc đơn vị ({1})!\nBạn có chắc muốn xóa đơn vị đang chọn?",
            //                                                    donvi.NhanSus.Count, donvi.Ten));
            //    if (res == DialogResult.No) return;
            //}

            treeList1.DeleteSelectedNodes();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            treeList1.CloseEditor();
            if (xpc.OfType<DonVi>().Any(c => string.IsNullOrEmpty(c.Ma) || string.IsNullOrEmpty(c.Ten))) return false;
            // Chưa kiểm tra được trùng mã

            return base.OnLuu();
        }
        protected override void OnXuatExcel()
        {
            object tmp;
            Param.GetValue("Đường dẫn lưu tải về", out tmp);
            bool b = clsHeThong.IsOffice2003();
            string tentep = string.Format(@"{0}\[{1}]-DonVi-{2:ddMMyyyy}.{3}", 
                                          tmp, clsHeThong.NienKhoaSuDung.Ten, DateTime.Today, b ? "xls" : "xlsx");

            if (b) treeList1.ExportToXls(tentep);
            else treeList1.ExportToXlsx(tentep);
        }
        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Node.HasChildren)
            {
                e.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                e.Appearance.Options.UseTextOptions = true;
            }
        }
    }
}