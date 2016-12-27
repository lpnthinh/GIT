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

namespace QuanLyDoanVien.NghiepVu
{
    public partial class FrmNienKhoa : FrmBase
    {
        public FrmNienKhoa()
        {
            InitializeComponent();
            Printable = gridControlCustom1;
            OnNap();
        }
        protected override void OnNap()
        {
            base.OnNap();
            xpc.Reload();
        }
        protected override void OnThem()
        {
            gridViewCustom1.AddNewRow();
        }
        protected override void OnXoa()
        {
            if (gridViewCustom1.SelectedRowsCount == 0) return;
            var res = MsgBox.ShowYesNoDialog(string.Format("Bạn có chắc muốn xóa ({0}) dòng đang chọn?", gridViewCustom1.SelectedRowsCount));
            if (res == DialogResult.No) return;

            gridViewCustom1.DeleteSelectedRows();
            OnLuu();
        }
        protected override bool OnLuu()
        {
            gridViewCustom1.CloseEditor();
            gridViewCustom1.UpdateCurrentRow();
            if (gridViewCustom1.HasError()) return false;

            if (base.OnLuu()) CapNhatDuLieu();

            return true;
        }
        bool CapNhatDuLieu()
        {
            try
            {
                // Cập nhật lên giao diện
                foreach (Form f in Application.OpenForms)
                {
                    var ftrangchu = f as FrmTrangChu;
                    if (ftrangchu != null) ftrangchu.NapNienKhoa();
                }

                //Cập nhật dữ liệu trên Form đang mở
                var openForms = Application.OpenForms;
                for (int i = 0; i < openForms.Count; i++)
                {
                    Form f = openForms[i];

                    var fbase = f as FrmBase;
                    if (fbase != null) fbase.NapLaiDuLieu();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }
        private void gridViewCustom1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "SuDung") return;

            foreach (NienKhoa nienkhoa in xpc)
            {
                nienkhoa.SuDung = false;
                nienkhoa.Save();
            }
        }
    }
}