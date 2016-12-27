namespace QuanLyDoanVien.HeThong
{
    partial class FrmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhanQuyen));
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colTenChucNang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcNguoiDung = new QuanLyDoanVien.TienIch.GridControlCustom();
            this.imcGrid = new DevExpress.Utils.ImageCollection(this.components);
            this.gvNguoiDung = new QuanLyDoanVien.TienIch.GridViewCustom();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoVaTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treePhanQuyen = new DevExpress.XtraTreeList.TreeList();
            this.colTruyCap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colThem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTatCa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imcTree = new DevExpress.Utils.ImageCollection(this.components);
            this.gcNhomNguoiDung = new QuanLyDoanVien.TienIch.GridControlCustom();
            this.xpcNhomNguoiDung = new DevExpress.Xpo.XPCollection(this.components);
            this.gvNhomNguoiDung = new QuanLyDoanVien.TienIch.GridViewCustom();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupNguoiDung = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpcChucNang = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // colTenChucNang
            // 
            this.colTenChucNang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenChucNang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenChucNang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenChucNang.Caption = "Chức năng";
            this.colTenChucNang.FieldName = "TenChucNang";
            this.colTenChucNang.MinWidth = 34;
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.OptionsColumn.AllowEdit = false;
            this.colTenChucNang.Visible = true;
            this.colTenChucNang.VisibleIndex = 0;
            this.colTenChucNang.Width = 198;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcNguoiDung);
            this.layoutControl1.Controls.Add(this.treePhanQuyen);
            this.layoutControl1.Controls.Add(this.gcNhomNguoiDung);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 29);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(984, 410);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcNguoiDung
            // 
            this.gcNguoiDung.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.ImageList = this.imcGrid;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 0, true, true, "Thêm người dùng", "ThemNguoiDung"),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 1, true, true, "Xóa người dùng", "XoaNguoiDung"),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 2, true, true, "Đặt lại mật khẩu", "DatLaiMatKhau")});
            this.gcNguoiDung.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gcNguoiDung.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcNguoiDung_EmbeddedNavigator_ButtonClick);
            this.gcNguoiDung.Location = new System.Drawing.Point(24, 238);
            this.gcNguoiDung.MainView = this.gvNguoiDung;
            this.gcNguoiDung.MenuManager = this.BM;
            this.gcNguoiDung.Name = "gcNguoiDung";
            this.gcNguoiDung.Size = new System.Drawing.Size(311, 148);
            this.gcNguoiDung.TabIndex = 6;
            this.gcNguoiDung.UseEmbeddedNavigator = true;
            this.gcNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            // 
            // imcGrid
            // 
            this.imcGrid.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imcGrid.ImageStream")));
            this.imcGrid.InsertGalleryImage("additem_16x16.png", "images/actions/additem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_16x16.png"), 0);
            this.imcGrid.Images.SetKeyName(0, "additem_16x16.png");
            this.imcGrid.InsertGalleryImage("deletelist_16x16.png", "images/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist_16x16.png"), 1);
            this.imcGrid.Images.SetKeyName(1, "deletelist_16x16.png");
            this.imcGrid.InsertGalleryImage("refresh_16x16.png", "images/actions/refresh_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_16x16.png"), 2);
            this.imcGrid.Images.SetKeyName(2, "refresh_16x16.png");
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gvNguoiDung.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNguoiDung.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvNguoiDung.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvNguoiDung.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvNguoiDung.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gvNguoiDung.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvNguoiDung.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaiKhoan,
            this.colHoVaTen,
            this.colHoatDong});
            this.gvNguoiDung.FixedLineWidth = 1;
            this.gvNguoiDung.GridControl = this.gcNguoiDung;
            this.gvNguoiDung.GroupFormat = "[#image]{1} {2}";
            this.gvNguoiDung.IndicatorWidth = 40;
            this.gvNguoiDung.KeyColumn = null;
            this.gvNguoiDung.Name = "gvNguoiDung";
            this.gvNguoiDung.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvNguoiDung.OptionsDetail.EnableMasterViewMode = false;
            this.gvNguoiDung.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvNguoiDung.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvNguoiDung.OptionsSelection.InvertSelection = true;
            this.gvNguoiDung.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gvNguoiDung.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNguoiDung.OptionsView.ShowAutoFilterRow = true;
            this.gvNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNguoiDung.DoubleClick += new System.EventHandler(this.gvNguoiDung_DoubleClick);
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.Caption = "Tài khoản";
            this.colTaiKhoan.FieldName = "TaiKhoan";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.OptionsColumn.AllowEdit = false;
            this.colTaiKhoan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 0;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.Caption = "Họ và tên";
            this.colHoVaTen.FieldName = "HoVaTen";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHoVaTen.Visible = true;
            this.colHoVaTen.VisibleIndex = 1;
            // 
            // colHoatDong
            // 
            this.colHoatDong.Caption = "Hoạt động";
            this.colHoatDong.FieldName = "HoatDong";
            this.colHoatDong.Name = "colHoatDong";
            this.colHoatDong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHoatDong.Visible = true;
            this.colHoatDong.VisibleIndex = 2;
            // 
            // treePhanQuyen
            // 
            this.treePhanQuyen.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTenChucNang,
            this.colTruyCap,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colTatCa});
            this.treePhanQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            treeListFormatRule1.ApplyToRow = true;
            treeListFormatRule1.Column = this.colTenChucNang;
            treeListFormatRule1.ColumnApplyTo = this.colTenChucNang;
            treeListFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Expression = "[TenChucNang] = \'Tất cả\'";
            treeListFormatRule1.Rule = formatConditionRuleExpression1;
            this.treePhanQuyen.FormatRules.Add(treeListFormatRule1);
            this.treePhanQuyen.KeyFieldName = "Id";
            this.treePhanQuyen.Location = new System.Drawing.Point(363, 43);
            this.treePhanQuyen.Name = "treePhanQuyen";
            this.treePhanQuyen.OptionsView.ShowHorzLines = false;
            this.treePhanQuyen.OptionsView.ShowIndicator = false;
            this.treePhanQuyen.OptionsView.ShowVertLines = false;
            this.treePhanQuyen.ParentFieldName = "IdCha";
            this.treePhanQuyen.SelectImageList = this.imcTree;
            this.treePhanQuyen.Size = new System.Drawing.Size(597, 343);
            this.treePhanQuyen.TabIndex = 5;
            this.treePhanQuyen.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treePhanQuyen_CustomDrawNodeCell);
            this.treePhanQuyen.CustomDrawNodeImages += new DevExpress.XtraTreeList.CustomDrawNodeImagesEventHandler(this.treePhanQuyen_CustomDrawNodeImages);
            this.treePhanQuyen.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treePhanQuyen_CellValueChanging);
            // 
            // colTruyCap
            // 
            this.colTruyCap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTruyCap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTruyCap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTruyCap.Caption = "Truy cập";
            this.colTruyCap.FieldName = "TruyCap";
            this.colTruyCap.Name = "colTruyCap";
            this.colTruyCap.Visible = true;
            this.colTruyCap.VisibleIndex = 1;
            this.colTruyCap.Width = 79;
            // 
            // colThem
            // 
            this.colThem.AppearanceHeader.Options.UseTextOptions = true;
            this.colThem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThem.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colThem.Caption = "Thêm";
            this.colThem.FieldName = "Them";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 2;
            this.colThem.Width = 79;
            // 
            // colSua
            // 
            this.colSua.AppearanceHeader.Options.UseTextOptions = true;
            this.colSua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSua.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSua.Caption = "Sửa";
            this.colSua.FieldName = "Sua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 3;
            this.colSua.Width = 79;
            // 
            // colXoa
            // 
            this.colXoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colXoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colXoa.Caption = "Xóa";
            this.colXoa.FieldName = "Xoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 4;
            this.colXoa.Width = 80;
            // 
            // colTatCa
            // 
            this.colTatCa.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
            this.colTatCa.AppearanceCell.Options.UseBackColor = true;
            this.colTatCa.AppearanceHeader.Options.UseTextOptions = true;
            this.colTatCa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTatCa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTatCa.Caption = "Tất cả";
            this.colTatCa.FieldName = "TatCa";
            this.colTatCa.Name = "colTatCa";
            this.colTatCa.Visible = true;
            this.colTatCa.VisibleIndex = 5;
            this.colTatCa.Width = 80;
            // 
            // imcTree
            // 
            this.imcTree.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imcTree.ImageStream")));
            this.imcTree.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 0);
            this.imcTree.Images.SetKeyName(0, "home_16x16.png");
            this.imcTree.InsertGalleryImage("suggestion_16x16.png", "images/support/suggestion_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/suggestion_16x16.png"), 1);
            this.imcTree.Images.SetKeyName(1, "suggestion_16x16.png");
            this.imcTree.InsertGalleryImage("feature_16x16.png", "images/support/feature_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/feature_16x16.png"), 2);
            this.imcTree.Images.SetKeyName(2, "feature_16x16.png");
            this.imcTree.InsertGalleryImage("geopoint_16x16.png", "images/maps/geopoint_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/maps/geopoint_16x16.png"), 3);
            this.imcTree.Images.SetKeyName(3, "geopoint_16x16.png");
            // 
            // gcNhomNguoiDung
            // 
            this.gcNhomNguoiDung.DataSource = this.xpcNhomNguoiDung;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.ImageList = this.imcGrid;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNhomNguoiDung.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 0, true, true, "Thêm nhóm", "ThemNhom"),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 1, true, true, "Xóa nhóm", "XoaNhom")});
            this.gcNhomNguoiDung.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gcNhomNguoiDung.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcNhomNguoiDung_EmbeddedNavigator_ButtonClick);
            this.gcNhomNguoiDung.Location = new System.Drawing.Point(24, 43);
            this.gcNhomNguoiDung.MainView = this.gvNhomNguoiDung;
            this.gcNhomNguoiDung.MenuManager = this.BM;
            this.gcNhomNguoiDung.Name = "gcNhomNguoiDung";
            this.gcNhomNguoiDung.Size = new System.Drawing.Size(311, 148);
            this.gcNhomNguoiDung.TabIndex = 4;
            this.gcNhomNguoiDung.UseEmbeddedNavigator = true;
            this.gcNhomNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomNguoiDung});
            // 
            // xpcNhomNguoiDung
            // 
            this.xpcNhomNguoiDung.DeleteObjectOnRemove = true;
            this.xpcNhomNguoiDung.DisplayableProperties = "TenNhom";
            this.xpcNhomNguoiDung.ObjectType = typeof(QuanLyDoanVien.DuLieu.NhomNguoiDung);
            this.xpcNhomNguoiDung.Session = this.UOW;
            // 
            // gvNhomNguoiDung
            // 
            this.gvNhomNguoiDung.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gvNhomNguoiDung.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNhomNguoiDung.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvNhomNguoiDung.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvNhomNguoiDung.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvNhomNguoiDung.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gvNhomNguoiDung.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvNhomNguoiDung.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvNhomNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNhom});
            this.gvNhomNguoiDung.FixedLineWidth = 1;
            this.gvNhomNguoiDung.GridControl = this.gcNhomNguoiDung;
            this.gvNhomNguoiDung.GroupFormat = "[#image]{1} {2}";
            this.gvNhomNguoiDung.IndicatorWidth = 40;
            this.gvNhomNguoiDung.KeyColumn = null;
            this.gvNhomNguoiDung.Name = "gvNhomNguoiDung";
            this.gvNhomNguoiDung.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvNhomNguoiDung.OptionsDetail.EnableMasterViewMode = false;
            this.gvNhomNguoiDung.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvNhomNguoiDung.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvNhomNguoiDung.OptionsSelection.InvertSelection = true;
            this.gvNhomNguoiDung.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gvNhomNguoiDung.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNhomNguoiDung.OptionsView.ShowAutoFilterRow = true;
            this.gvNhomNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNhomNguoiDung.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhomNguoiDung_FocusedRowChanged);
            // 
            // colTenNhom
            // 
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroupNguoiDung});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(984, 410);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(339, 195);
            this.layoutControlGroup2.Text = "Nhóm người dùng";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcNhomNguoiDung;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(315, 152);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(339, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(625, 390);
            this.layoutControlGroup3.Text = "Phân quyền theo chức năng";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.treePhanQuyen;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(601, 347);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroupNguoiDung
            // 
            this.layoutControlGroupNguoiDung.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroupNguoiDung.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroupNguoiDung.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroupNguoiDung.Location = new System.Drawing.Point(0, 195);
            this.layoutControlGroupNguoiDung.Name = "layoutControlGroupNguoiDung";
            this.layoutControlGroupNguoiDung.Size = new System.Drawing.Size(339, 195);
            this.layoutControlGroupNguoiDung.Text = "Người dùng";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcNguoiDung;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(315, 152);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // xpcChucNang
            // 
            this.xpcChucNang.DisplayableProperties = "Id;Ten;Cha.Id";
            this.xpcChucNang.ObjectType = typeof(QuanLyDoanVien.DuLieu.ChucNang);
            this.xpcChucNang.Session = this.UOW;
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 439);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPhanQuyen";
            this.Text = "Phân quyền";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private TienIch.GridControlCustom gcNguoiDung;
        private TienIch.GridViewCustom gvNguoiDung;
        private DevExpress.XtraTreeList.TreeList treePhanQuyen;
        private TienIch.GridControlCustom gcNhomNguoiDung;
        private TienIch.GridViewCustom gvNhomNguoiDung;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupNguoiDung;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenChucNang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTruyCap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTatCa;
        private DevExpress.Xpo.XPCollection xpcNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colHoVaTen;
        private DevExpress.XtraGrid.Columns.GridColumn colHoatDong;
        private DevExpress.Utils.ImageCollection imcGrid;
        private DevExpress.Utils.ImageCollection imcTree;
        private DevExpress.Xpo.XPCollection xpcChucNang;
    }
}