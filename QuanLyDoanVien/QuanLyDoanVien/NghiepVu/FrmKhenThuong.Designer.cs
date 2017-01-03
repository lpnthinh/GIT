namespace QuanLyDoanVien.NghiepVu
{
    partial class FrmKhenThuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhenThuong));
            this.xpc = new DevExpress.Xpo.XPCollection(this.components);
            this.gridControlCustom1 = new QuanLyDoanVien.TienIch.GridControlCustom();
            this.gridViewCustom1 = new QuanLyDoanVien.TienIch.GridViewCustom();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDungKhenThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKhenThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustom1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawDragBorder = false;
            this.TB.OptionsBar.UseWholeRow = true;
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.Image")));
            this.btnXuatExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.LargeImage")));
            // 
            // btnXemVaIn
            // 
            this.btnXemVaIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.Image")));
            this.btnXemVaIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.LargeImage")));
            // 
            // btnNap
            // 
            this.btnNap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.Image")));
            this.btnNap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.LargeImage")));
            // 
            // xpc
            // 
            this.xpc.DeleteObjectOnRemove = true;
            this.xpc.DisplayableProperties = "NhanSu.SoHoSo;NhanSu.HoDem;NhanSu.Ten;NhanSu.DonVi.MaVaTen;HinhThucKhenThuong.Ten" +
    ";NoiDungKhenThuong;NgayKhenThuong";
            this.xpc.ObjectType = typeof(QuanLyDoanVien.DuLieu.KhenThuong);
            this.xpc.Session = this.UOW;
            // 
            // gridControlCustom1
            // 
            this.gridControlCustom1.DataSource = this.xpc;
            this.gridControlCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustom1.Location = new System.Drawing.Point(0, 29);
            this.gridControlCustom1.MainView = this.gridViewCustom1;
            this.gridControlCustom1.MenuManager = this.BM;
            this.gridControlCustom1.Name = "gridControlCustom1";
            this.gridControlCustom1.Size = new System.Drawing.Size(884, 333);
            this.gridControlCustom1.TabIndex = 4;
            this.gridControlCustom1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustom1});
            // 
            // gridViewCustom1
            // 
            this.gridViewCustom1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gridViewCustom1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCustom1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustom1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustom1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCustom1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustom1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustom1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCustom1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colNoiDungKhenThuong,
            this.colNgayKhenThuong});
            this.gridViewCustom1.FixedLineWidth = 1;
            this.gridViewCustom1.GridControl = this.gridControlCustom1;
            this.gridViewCustom1.GroupFormat = "[#image]{1} {2}";
            this.gridViewCustom1.IndicatorWidth = 40;
            this.gridViewCustom1.KeyColumn = null;
            this.gridViewCustom1.Name = "gridViewCustom1";
            this.gridViewCustom1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewCustom1.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewCustom1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridViewCustom1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridViewCustom1.OptionsSelection.InvertSelection = true;
            this.gridViewCustom1.OptionsSelection.MultiSelect = true;
            this.gridViewCustom1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewCustom1.OptionsView.ColumnAutoWidth = false;
            this.gridViewCustom1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCustom1.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCustom1.OptionsView.ShowFooter = true;
            this.gridViewCustom1.OptionsView.ShowGroupPanel = false;
            this.gridViewCustom1.DoubleClick += new System.EventHandler(this.gridViewCustom1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.FieldName = "NhanSu.SoHoSo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NhanSu.SoHoSo", "Số dòng: {0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 90;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "NhanSu.HoDem";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 110;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "NhanSu.Ten";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "NhanSu.DonVi.MaVaTen";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 161;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Hình thức KT";
            this.gridColumn5.FieldName = "HinhThucKhenThuong.Ten";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 93;
            // 
            // colNoiDungKhenThuong
            // 
            this.colNoiDungKhenThuong.FieldName = "NoiDungKhenThuong";
            this.colNoiDungKhenThuong.Name = "colNoiDungKhenThuong";
            this.colNoiDungKhenThuong.OptionsColumn.AllowEdit = false;
            this.colNoiDungKhenThuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNoiDungKhenThuong.Visible = true;
            this.colNoiDungKhenThuong.VisibleIndex = 5;
            this.colNoiDungKhenThuong.Width = 239;
            // 
            // colNgayKhenThuong
            // 
            this.colNgayKhenThuong.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayKhenThuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayKhenThuong.FieldName = "NgayKhenThuong";
            this.colNgayKhenThuong.Name = "colNgayKhenThuong";
            this.colNgayKhenThuong.OptionsColumn.AllowEdit = false;
            this.colNgayKhenThuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgayKhenThuong.Visible = true;
            this.colNgayKhenThuong.VisibleIndex = 6;
            this.colNgayKhenThuong.Width = 82;
            // 
            // FrmKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.gridControlCustom1);
            this.Name = "FrmKhenThuong";
            this.Text = "Quản lý khen thưởng";
            this.Controls.SetChildIndex(this.gridControlCustom1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpc;
        private TienIch.GridControlCustom gridControlCustom1;
        private TienIch.GridViewCustom gridViewCustom1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDungKhenThuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKhenThuong;
    }
}