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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using DevExpress.Data.Filtering;

namespace QuanLyDoanVien.HeThong
{
    public partial class FrmPhanQuyen : FrmBase
    {
        public FrmPhanQuyen()
        {
            InitializeComponent();

            treePhanQuyen.ExpandAll();
            Skin skin = GridSkins.GetSkin(treePhanQuyen.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
        }
        protected override void OnNap()
        {
            base.OnNap();
            xpcNhomNguoiDung.Reload();
            foreach (NhomNguoiDung nhom in xpcNhomNguoiDung)
            {
                nhom.Reload();
                nhom.NguoiDungs.Reload();
            }

            NapDuLieuChucNang();
        }
        protected override bool OnLuu()
        {
            gvNhomNguoiDung.CloseEditor();
            gvNhomNguoiDung.UpdateCurrentRow();

            gvNguoiDung.CloseEditor();
            gvNguoiDung.UpdateCurrentRow();

            if (gvNhomNguoiDung.HasError()) return false;
            if (gvNguoiDung.HasError()) return false;

            return base.OnLuu();
        }
        private void NapDuLieuChucNang()
        {
            NhomNguoiDung group = gvNhomNguoiDung.GetFocusedRow() as NhomNguoiDung;
            if (group == null) return;

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("TenChucNang");
            dt.Columns.Add("IdCha", typeof(int));
            dt.Columns.Add("TruyCap", typeof(bool));
            dt.Columns.Add("Them", typeof(bool));
            dt.Columns.Add("Sua", typeof(bool));
            dt.Columns.Add("Xoa", typeof(bool));
            dt.Columns.Add("TatCa", typeof(bool));

            DataRow rAll = dt.NewRow();
            rAll["Id"] = 0;
            rAll["TenChucNang"] = "Tất cả";
            rAll["IdCha"] = 0;
            dt.Rows.Add(rAll);

            bool truycap = true;
            bool them = true;
            bool sua = true;
            bool xoa = true;
            bool tatca = true;
            foreach (ChucNang m in xpcChucNang)
            {
                DataRow row = dt.NewRow();
                row["Id"] = m.Id;
                row["TenChucNang"] = m.Ten;
                if (m.Cha != null)
                    row["IdCha"] = m.Cha.Id;

                string strFilter = string.Format("NhomNguoiDung.Id = ? and ChucNang.Id =?");
                var umf = UOW.FindObject<PhanQuyen>(CriteriaOperator.Parse(strFilter, group.Id, m.Id));

                row["TruyCap"] = umf == null ? false : umf.TruyCap;
                row["Them"] = umf == null ? false : umf.Them;
                row["Sua"] = umf == null ? false : umf.Sua;
                row["Xoa"] = umf == null ? false : umf.Xoa;
                row["TatCa"] = umf == null ? false : (umf.TruyCap & umf.Them & umf.Sua & umf.Xoa);

                dt.Rows.Add(row);

                truycap &= Convert.ToBoolean(row["TruyCap"]);
                them &= Convert.ToBoolean(row["Them"]);
                sua &= Convert.ToBoolean(row["Sua"]);
                xoa &= Convert.ToBoolean(row["Xoa"]);
                tatca &= Convert.ToBoolean(row["TatCa"]);
            }

            rAll["TruyCap"] = truycap;
            rAll["Them"] = them;
            rAll["Sua"] = sua;
            rAll["Xoa"] = xoa;
            rAll["TatCa"] = tatca;

            dt.AcceptChanges();
            treePhanQuyen.DataSource = dt;
            treePhanQuyen.ExpandAll();
        }
        private void ThongTinNguoiDung()
        {
            var nguoidung = gvNguoiDung.GetFocusedRow() as NguoiDung;
            if (nguoidung == null) return;
            var f = new FrmNguoiDung(nguoidung);
            if (f.ShowDialog() == DialogResult.OK) OnLuu(); ;
            OnNap();
        }
        private void gcNhomNguoiDung_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.Tag.ToString().Equals("ThemNhom"))
            {
                gvNhomNguoiDung.AddNewRow();
            }

            if (e.Button.Tag.ToString().Equals("XoaNhom"))
            {
                var nhom = gvNhomNguoiDung.GetFocusedRow() as NhomNguoiDung;
                if (nhom == null) return;

                if (nhom.QuanTri)
                {
                    MsgBox.ShowWarningDialog("Bạn không thể xóa nhóm quản trị");
                    return;
                }

                if (MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa nhóm [{0}]?", nhom.TenNhom)) == DialogResult.No) return;

                nhom.Delete();
                OnLuu();
            }

            e.Handled = true;
        }
        private void gcNguoiDung_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.Tag.ToString().Equals("ThemNguoiDung"))
            {
                gvNguoiDung.AddNewRow();
                ThongTinNguoiDung();
            }

            if (e.Button.Tag.ToString().Equals("XoaNguoiDung"))
            {
                var nguoidung = gvNguoiDung.GetFocusedRow() as NguoiDung;
                if (nguoidung == null) return;

                if (nguoidung.QuanTri)
                {
                    MsgBox.ShowWarningDialog("Bạn không thể xóa người dùng quản trị");
                    return;
                }

                if (MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa người dùng [{0}]?", nguoidung.TaiKhoan)) == DialogResult.No) return;

                nguoidung.Delete();
                OnLuu();
            }

            if (e.Button.Tag.ToString().Equals("DatLaiMatKhau"))
            {
                var nguoidung = gvNguoiDung.GetFocusedRow() as NguoiDung;
                if (nguoidung == null) return;

                if (DialogResult.Yes == MsgBox.ShowYesNoDialog(string.Format("Bạn muốn đặt lại mật khẩu cho tài khoản [{0}]?", nguoidung.TaiKhoan)))
                {
                    object tmp;
                    Param.GetValue("Tạo mã bằng chữ in hoa", out tmp);

                    string matkhaumoi = Generate.Random((bool)tmp);
                    nguoidung.SetPassword(matkhaumoi);

                    if (OnLuu())
                    {
                        Clipboard.SetText(matkhaumoi);
                        MsgBox.ShowSuccessfulDialog(string.Format("Mật khẩu mới của tài khoản [{0}] là: {1}\nMật khẩu đã được sao chép vào Clipboard.", 
                                                    nguoidung.TaiKhoan, matkhaumoi));
                    }
                }
            }

            e.Handled = true;
        }
        private void gvNhomNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var nhom = gvNhomNguoiDung.GetFocusedRow() as NhomNguoiDung;
            if (nhom == null) return;

            layoutControlGroupNguoiDung.Text = string.IsNullOrEmpty(nhom.TenNhom) ? "Người dùng" : string.Format("Người dùng nhóm [{0}]", nhom.TenNhom);
            nhom.NguoiDungs.DeleteObjectOnRemove = true;
            gcNguoiDung.DataSource = nhom.NguoiDungs;

            NapDuLieuChucNang();
        }
        private void gvNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            ThongTinNguoiDung();
        }
        private void SetCheckedChildNodes(TreeListNode node, TreeListColumn col, bool check)
        {
            if (col == colTatCa)
            {
                node[colTruyCap] = check;
                node[colThem] = check;
                node[colSua] = check;
                node[colXoa] = check;
                node[colTatCa] = check;
            }
            else
            {
                bool allowShow = (bool)node.GetValue(colTruyCap);
                bool allowAddNew = (bool)node.GetValue(colThem);
                bool allowEdit = (bool)node.GetValue(colSua);
                bool allowDelete = (bool)node.GetValue(colXoa);

                node[colTatCa] = allowShow & allowAddNew & allowEdit & allowDelete;
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i][col] = check;
                if (col == colTatCa)
                {
                    node.Nodes[i][colTruyCap] = check;
                    node.Nodes[i][colThem] = check;
                    node.Nodes[i][colSua] = check;
                    node.Nodes[i][colXoa] = check;
                }
                SetCheckedChildNodes(node.Nodes[i], col, check);
            }

        }
        private void SetCheckedParentNodes(TreeListNode node, TreeListColumn col, bool check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                bool state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (bool)node.ParentNode.Nodes[i][col];
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                bool bb = b ? false : check;
                node.ParentNode[col] = bb;

                if (col == colTatCa)
                {
                    node.ParentNode[colTruyCap] = bb;
                    node.ParentNode[colThem] = bb;
                    node.ParentNode[colSua] = bb;
                    node.ParentNode[colXoa] = bb;
                }
                else
                {
                    bool allowShow = (bool)node.ParentNode.GetValue(colTruyCap);
                    bool allowAddNew = (bool)node.ParentNode.GetValue(colThem);
                    bool allowEdit = (bool)node.ParentNode.GetValue(colSua);
                    bool allowDelete = (bool)node.ParentNode.GetValue(colXoa);

                    node.ParentNode[colTatCa] = allowShow & allowAddNew & allowEdit & allowDelete;
                }
                SetCheckedParentNodes(node.ParentNode, col, check);
            }
        }
        private void treePhanQuyen_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            MsgBox.ShowWaitForm("Đang thực hiện ...");
            var group = gvNhomNguoiDung.GetFocusedRow() as NhomNguoiDung;
            if (group == null) return;

            e.Node.SetValue(e.Column, e.Value);
            DataRowView rowView = treePhanQuyen.GetDataRecordByNode(e.Node) as DataRowView;
            if (rowView != null)
            {
                var function = xpcChucNang.Lookup(rowView["Id"]) as ChucNang;
                if (function != null)
                {
                    if (e.Column.FieldName.Equals("TatCa"))
                    {
                        rowView["TruyCap"] = rowView["Them"] = rowView["Sua"] = rowView["Xoa"] = e.Value;
                    }
                    var quyen = PhanQuyen.FindAndNew(UOW, group, function);
                    quyen.TruyCap = Convert.ToBoolean(rowView["TruyCap"]);
                    quyen.Them = Convert.ToBoolean(rowView["Them"]);
                    quyen.Sua = Convert.ToBoolean(rowView["Sua"]);
                    quyen.Xoa = Convert.ToBoolean(rowView["Xoa"]);
                    quyen.Save();
                }
            }

            SetCheckedChildNodes(e.Node, e.Column, (bool)e.Value);
            SetCheckedParentNodes(e.Node, e.Column, (bool)e.Value);

            DataTable dt = treePhanQuyen.DataSource as DataTable;
            if (dt == null) return;

            DataTable dtChanges = dt.GetChanges();
            if (dtChanges == null) return;

            foreach (DataRow row in dtChanges.Rows)
            {
                var function = xpcChucNang.Lookup(row["Id"]) as ChucNang;
                if (function == null) continue;

                var quyen = PhanQuyen.FindAndNew(UOW, group, function);
                quyen.TruyCap = Convert.ToBoolean(row["TruyCap"]);
                quyen.Them = Convert.ToBoolean(row["Them"]);
                quyen.Sua = Convert.ToBoolean(row["Sua"]);
                quyen.Xoa = Convert.ToBoolean(row["Xoa"]);
                quyen.Save();
            }
            MsgBox.CloseWaitForm();
        }
        private void treePhanQuyen_CustomDrawNodeImages(object sender, DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
            if (e.Node.Level > 4)
                e.SelectImageIndex = 4;
        }
        private void treePhanQuyen_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Node.HasChildren)
            {
                e.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                e.Appearance.Options.UseTextOptions = true;
            }
        }
    }
}