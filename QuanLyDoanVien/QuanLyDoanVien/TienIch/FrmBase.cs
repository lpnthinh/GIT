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
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace QuanLyDoanVien.TienIch
{
    public partial class FrmBase : DevExpress.XtraEditors.XtraForm
    {
        ChucNang chucnangdangchon;
        public FrmBase()
        {
            InitializeComponent();
            chucnangdangchon = clsHeThong.ChucNangDangChon;
        }
        private void FrmBase_Activated(object sender, EventArgs e)
        {
            PhanQuyen p = PhanQuyen.Find(clsDuLieu.NguoiDungDangNhap.Nhom, chucnangdangchon);
            if (p == null) return;

            if (!p.TruyCap && !IsInitializing)
            {
                MsgBox.ShowWarningDialog("Bạn không có quyền truy cập chức năng này");
                this.Close();
            }

            btnThem.Enabled = p.Them;
            btnSua.Enabled = p.Sua;
            btnXoa.Enabled = p.Xoa;
            btnLuu.Enabled = p.Sua | p.Them;
        }
        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MsgBox.ShowWaitForm();
            OnNap();
            MsgBox.CloseWaitForm();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnThem();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnSua();
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnXoa();
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnLuu();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDong();
        }
        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnXuatExcel();
        }
        private void btnXemVaIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnXemVaIn();
        }

        #region Hàm
        public bool IsChanged
        {
            get
            {
                return UOW.GetObjectsToSave().Count > 0 || UOW.GetObjectsToDelete().Count > 0;
                //return UOW.TrackingChanges; 
            }
        }
        protected virtual void OnNap()
        {
            UOW.ReloadChangedObjects();
        }
        public void NapLaiDuLieu()
        {
            MsgBox.ShowWaitForm();
            OnNap();
            MsgBox.CloseWaitForm();
        }
        protected virtual void OnThem()
        {

        }
        protected virtual void OnSua()
        {

        }
        protected virtual void OnXoa()
        {

        }
        protected virtual bool OnLuu()
        {
            if (!IsChanged) return true;

            try
            {
                UOW.CommitChanges();
                MsgBox.ShowSuccessfulDialog("Đã xử lý thành công");
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }
        protected virtual void OnDong()
        {
            Close();
        }
        protected virtual void OnXuatExcel()
        {

        }
        protected virtual void OnXemVaIn()
        {
            MsgBox.ShowWaitForm();
            OnPrintPreview();
            MsgBox.CloseWaitForm();
        }
        #endregion

        #region In mặc định
        private IPrintable _print;
        protected IPrintable Printable
        {
            get { return _print; }
            set
            {
                _print = value;

                #region Thiết kế trước khi in
                if (_print != null)
                {
                    var g = Printable as GridControl;
                    if (g != null)
                    {
                        foreach (BaseView v in g.ViewCollection)
                        {
                            var view = v as GridView;
                            if (view != null)
                            {
                                view.AppearancePrint.EvenRow.BackColor = Color.FromArgb(239, 243, 250);
                                view.AppearancePrint.EvenRow.BorderColor = Color.FromArgb(175, 190, 216);
                                view.AppearancePrint.EvenRow.Options.UseBackColor = true;
                                view.AppearancePrint.EvenRow.Options.UseBorderColor = true;

                                view.AppearancePrint.FooterPanel.BackColor = Color.LightYellow;
                                view.AppearancePrint.FooterPanel.Options.UseBackColor = true;
                                view.AppearancePrint.FooterPanel.Font = new Font("Times New Roman", 12F);
                                view.AppearancePrint.FooterPanel.Options.UseBorderColor = true;
                                view.AppearancePrint.FooterPanel.Options.UseFont = true;
                                view.AppearancePrint.FooterPanel.Options.UseForeColor = true;
                                view.AppearancePrint.FooterPanel.ForeColor = Color.DarkRed;
                                view.AppearancePrint.FooterPanel.BorderColor = Color.FromArgb(175, 190, 216);

                                view.AppearancePrint.GroupFooter.BackColor = Color.FromArgb(255, 253, 234);
                                view.AppearancePrint.GroupFooter.Options.UseBackColor = true;
                                view.AppearancePrint.GroupRow.BackColor = Color.FromArgb(249, 255, 242);
                                view.AppearancePrint.GroupRow.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
                                view.AppearancePrint.GroupRow.Options.UseBackColor = true;
                                view.AppearancePrint.GroupRow.Options.UseFont = true;
                                view.AppearancePrint.HeaderPanel.BackColor = Color.FromArgb(201, 214, 237);
                                view.AppearancePrint.HeaderPanel.BorderColor = Color.FromArgb(175, 190, 216);
                                view.AppearancePrint.HeaderPanel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
                                view.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
                                view.AppearancePrint.HeaderPanel.Options.UseBorderColor = true;
                                view.AppearancePrint.HeaderPanel.Options.UseFont = true;
                                view.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
                                view.AppearancePrint.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
                                view.AppearancePrint.HeaderPanel.TextOptions.VAlignment = VertAlignment.Center;
                                view.AppearancePrint.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap;
                                view.AppearancePrint.Lines.BackColor = Color.FromArgb(175, 190, 216);
                                view.AppearancePrint.Lines.BorderColor = Color.FromArgb(175, 190, 216);
                                view.AppearancePrint.Lines.Options.UseBackColor = true;
                                view.AppearancePrint.Lines.Options.UseBorderColor = true;
                                view.AppearancePrint.Row.BorderColor = Color.FromArgb(175, 190, 216);
                                view.AppearancePrint.Row.Options.UseBorderColor = true;
                                view.AppearancePrint.Row.Font = new Font("Times New Roman", 12F);
                                view.AppearancePrint.Row.Options.UseBorderColor = true;
                                view.AppearancePrint.Row.Options.UseFont = true;

                                view.AppearancePrint.GroupFooter.BackColor = Color.FromArgb(240, 212, 194);
                                view.AppearancePrint.GroupFooter.Options.UseBackColor = true;
                                view.AppearancePrint.GroupFooter.Font = new Font("Times New Roman", 12F);
                                view.AppearancePrint.GroupFooter.Options.UseBorderColor = true;
                                view.AppearancePrint.GroupFooter.Options.UseFont = true;

                                view.OptionsPrint.EnableAppearanceEvenRow = true;
                            }
                        }
                    }
                }

                #endregion
            }
        }
        public WinControlContainer CopyGridControl(IPrintable grid)
        {
            var winContainer = new WinControlContainer() { Location = new Point(0, 0), Size = new Size(200, 100), WinControl = (grid as Control) };
            return winContainer;
        }
        protected PaperKind PageKind { get; set; }
        protected bool Landscape { get; set; }
        protected string ReportDate { get; set; }
        protected virtual void OnPrintPreview()
        {
            var r = new RptBase() { TenBaoCao = Text.ToUpper(), PaperKind = PageKind, Landscape = Landscape };
            r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(Printable));
            r.ShowPreview();
        }
        #endregion
    }
}