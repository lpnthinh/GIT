namespace QuanLyDoanVien.NghiepVu
{
    partial class FrmDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonVi));
            this.xpc = new DevExpress.Xpo.XPCollection(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colTen = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ricbCapDonVi = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colMaCapTren = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnThemCapDuoi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbCapDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // BM
            // 
            this.BM.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemCapDuoi});
            this.BM.MaxItemId = 9;
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCapDuoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuatExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.xpc.DisplayableProperties = "Id;Ten;Ma;Cap;Cha.Ma;Cha!Key";
            this.xpc.ObjectType = typeof(QuanLyDoanVien.DuLieu.DonVi);
            this.xpc.Session = this.UOW;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTen,
            this.colMa,
            this.colCap,
            this.colMaCapTren});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.xpc;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 29);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsNavigation.AutoFocusNewNode = true;
            this.treeList1.OptionsNavigation.UseTabKey = true;
            this.treeList1.OptionsSelection.InvertSelection = true;
            this.treeList1.OptionsSelection.MultiSelect = true;
            this.treeList1.OptionsSelection.SelectNodesOnRightClick = true;
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFullFocus;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "Cha!Key";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbCapDonVi});
            this.treeList1.RootValue = null;
            this.treeList1.Size = new System.Drawing.Size(584, 333);
            this.treeList1.TabIndex = 4;
            this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
            // 
            // colTen
            // 
            this.colTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 0;
            this.colTen.Width = 255;
            // 
            // colMa
            // 
            this.colMa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 1;
            this.colMa.Width = 100;
            // 
            // colCap
            // 
            this.colCap.AppearanceHeader.Options.UseTextOptions = true;
            this.colCap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCap.ColumnEdit = this.ricbCapDonVi;
            this.colCap.FieldName = "Cap";
            this.colCap.Name = "colCap";
            this.colCap.Visible = true;
            this.colCap.VisibleIndex = 2;
            this.colCap.Width = 100;
            // 
            // ricbCapDonVi
            // 
            this.ricbCapDonVi.AutoHeight = false;
            this.ricbCapDonVi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricbCapDonVi.Name = "ricbCapDonVi";
            // 
            // colMaCapTren
            // 
            this.colMaCapTren.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaCapTren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaCapTren.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaCapTren.Caption = "Mã cấp trên";
            this.colMaCapTren.FieldName = "Cha.Ma";
            this.colMaCapTren.Name = "colMaCapTren";
            this.colMaCapTren.Visible = true;
            this.colMaCapTren.VisibleIndex = 3;
            this.colMaCapTren.Width = 100;
            // 
            // btnThemCapDuoi
            // 
            this.btnThemCapDuoi.Caption = "Thêm cấp dưới";
            this.btnThemCapDuoi.Id = 8;
            this.btnThemCapDuoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCapDuoi.ImageOptions.Image")));
            this.btnThemCapDuoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemCapDuoi.ImageOptions.LargeImage")));
            this.btnThemCapDuoi.Name = "btnThemCapDuoi";
            this.btnThemCapDuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCapDuoi_ItemClick);
            // 
            // FrmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.treeList1);
            this.Name = "FrmDonVi";
            this.Text = "Đơn vị";
            this.Controls.SetChildIndex(this.treeList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbCapDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpc;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMaCapTren;
        private DevExpress.XtraBars.BarButtonItem btnThemCapDuoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ricbCapDonVi;
    }
}