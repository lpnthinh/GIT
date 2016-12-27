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
using DevExpress.Skins;
using QuanLyDoanVien.DuLieu;

namespace QuanLyDoanVien.DanhMuc
{
    public partial class FrmHanhChinh : FrmBase
    {
        public FrmHanhChinh()
        {
            InitializeComponent();

            Skin skin = GridSkins.GetSkin(treeList1.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            ricbCap.Items.AddEnum(typeof(CapHanhChinh), true);
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();
            xpc.Reload();
        }
        protected override void OnThem()
        {
            treeList1.AppendNode(null, null);
        }
        private void btnThemCapDuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nodeFocus = treeList1.FocusedNode;
            if (nodeFocus == null) return;

            treeList1.AppendNode(null, nodeFocus);
        }
        protected override void OnXoa()
        {
            if (treeList1.FocusedNode == null) return;
            if (treeList1.FocusedNode.HasChildren)
            {
                MsgBox.ShowWarningDialog("Không thể xóa vì có tồn tại cấp dưới!");
                return;
            }

            treeList1.DeleteSelectedNodes();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            treeList1.CloseEditor();
            if (xpc.OfType<HanhChinh>().Any(c => string.IsNullOrEmpty(c.Ma) || string.IsNullOrEmpty(c.Ten))) return false;

            return base.OnLuu();
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