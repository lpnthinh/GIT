namespace QuanLyDoanVien.NghiepVu
{
    partial class FrmKhenThuongDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhenThuongDialog));
            this.dxError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.xpcKhenThuong = new DevExpress.Xpo.XPCollection(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.DonViSLK = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpcDonVi = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhanSuSLK = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpcNhanSu = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HinhThucKhenThuongSLK = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpcHinhThucKhenThuong = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoiDungKhenThuongMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.NgayKhenThuongDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoiDungKhenThuong = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgayKhenThuong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.btnLuuVaThem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonViSLK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanSuSLK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhThucKhenThuongSLK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcHinhThucKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiDungKhenThuongMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKhenThuongDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKhenThuongDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiDungKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgayKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // BM
            // 
            this.BM.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLuuVaThem});
            this.BM.MaxItemId = 9;
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuVaThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawBorder = false;
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
            this.btnLuu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnLuu.Caption = "Lưu và đóng";
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            // 
            // btnDong
            // 
            this.btnDong.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
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
            // dxError
            // 
            this.dxError.ContainerControl = this;
            // 
            // xpcKhenThuong
            // 
            this.xpcKhenThuong.DisplayableProperties = "NhanSu!Key;HinhThucKhenThuong!Key;NoiDungKhenThuong;NgayKhenThuong";
            this.xpcKhenThuong.ObjectType = typeof(QuanLyDoanVien.DuLieu.KhenThuong);
            this.xpcKhenThuong.Session = this.UOW;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.DonViSLK);
            this.dataLayoutControl1.Controls.Add(this.NhanSuSLK);
            this.dataLayoutControl1.Controls.Add(this.HinhThucKhenThuongSLK);
            this.dataLayoutControl1.Controls.Add(this.NoiDungKhenThuongMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.NgayKhenThuongDateEdit);
            this.dataLayoutControl1.DataSource = this.xpcKhenThuong;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(649, 131, 450, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(484, 173);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // DonViSLK
            // 
            this.DonViSLK.Location = new System.Drawing.Point(76, 12);
            this.DonViSLK.MenuManager = this.BM;
            this.DonViSLK.Name = "DonViSLK";
            this.DonViSLK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DonViSLK.Properties.DataSource = this.xpcDonVi;
            this.DonViSLK.Properties.DisplayMember = "MaVaTen";
            this.DonViSLK.Properties.ValueMember = "Id";
            this.DonViSLK.Properties.View = this.searchLookUpEdit3View;
            this.DonViSLK.Size = new System.Drawing.Size(396, 20);
            this.DonViSLK.StyleController = this.dataLayoutControl1;
            this.DonViSLK.TabIndex = 8;
            this.DonViSLK.EditValueChanged += new System.EventHandler(this.DonViSLK_EditValueChanged);
            // 
            // xpcDonVi
            // 
            this.xpcDonVi.DisplayableProperties = "Id;MaVaTen";
            this.xpcDonVi.ObjectType = typeof(QuanLyDoanVien.DuLieu.DonVi);
            this.xpcDonVi.Session = this.UOW;
            // 
            // searchLookUpEdit3View
            // 
            this.searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // NhanSuSLK
            // 
            this.NhanSuSLK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpcKhenThuong, "NhanSu!Key", true));
            this.NhanSuSLK.Location = new System.Drawing.Point(76, 36);
            this.NhanSuSLK.MenuManager = this.BM;
            this.NhanSuSLK.Name = "NhanSuSLK";
            this.NhanSuSLK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NhanSuSLK.Properties.Appearance.Options.UseFont = true;
            this.NhanSuSLK.Properties.Appearance.Options.UseTextOptions = true;
            this.NhanSuSLK.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NhanSuSLK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NhanSuSLK.Properties.DataSource = this.xpcNhanSu;
            this.NhanSuSLK.Properties.DisplayMember = "ThongTinNhanSu";
            this.NhanSuSLK.Properties.NullText = "";
            this.NhanSuSLK.Properties.ValueMember = "Id";
            this.NhanSuSLK.Properties.View = this.searchLookUpEdit1View;
            this.NhanSuSLK.Size = new System.Drawing.Size(396, 20);
            this.NhanSuSLK.StyleController = this.dataLayoutControl1;
            this.NhanSuSLK.TabIndex = 4;
            // 
            // xpcNhanSu
            // 
            this.xpcNhanSu.DisplayableProperties = "Id;ThongTinNhanSu";
            this.xpcNhanSu.ObjectType = typeof(QuanLyDoanVien.DuLieu.NhanSu);
            this.xpcNhanSu.Session = this.UOW;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // HinhThucKhenThuongSLK
            // 
            this.HinhThucKhenThuongSLK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpcKhenThuong, "HinhThucKhenThuong!Key", true));
            this.HinhThucKhenThuongSLK.Location = new System.Drawing.Point(76, 60);
            this.HinhThucKhenThuongSLK.MenuManager = this.BM;
            this.HinhThucKhenThuongSLK.Name = "HinhThucKhenThuongSLK";
            this.HinhThucKhenThuongSLK.Properties.Appearance.Options.UseTextOptions = true;
            this.HinhThucKhenThuongSLK.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HinhThucKhenThuongSLK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HinhThucKhenThuongSLK.Properties.DataSource = this.xpcHinhThucKhenThuong;
            this.HinhThucKhenThuongSLK.Properties.DisplayMember = "Ten";
            this.HinhThucKhenThuongSLK.Properties.NullText = "";
            this.HinhThucKhenThuongSLK.Properties.ShowAddNewButton = true;
            this.HinhThucKhenThuongSLK.Properties.ValueMember = "Id";
            this.HinhThucKhenThuongSLK.Properties.View = this.searchLookUpEdit2View;
            this.HinhThucKhenThuongSLK.Size = new System.Drawing.Size(164, 20);
            this.HinhThucKhenThuongSLK.StyleController = this.dataLayoutControl1;
            this.HinhThucKhenThuongSLK.TabIndex = 5;
            this.HinhThucKhenThuongSLK.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.HinhThucKhenThuongSLK_AddNewValue);
            this.HinhThucKhenThuongSLK.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.HinhThucKhenThuongSLK_QueryPopUp);
            // 
            // xpcHinhThucKhenThuong
            // 
            this.xpcHinhThucKhenThuong.DisplayableProperties = "Id;Ten";
            this.xpcHinhThucKhenThuong.ObjectType = typeof(QuanLyDoanVien.DuLieu.HinhThucKhenThuong);
            this.xpcHinhThucKhenThuong.Session = this.UOW;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // NoiDungKhenThuongMemoEdit
            // 
            this.NoiDungKhenThuongMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpcKhenThuong, "NoiDungKhenThuong", true));
            this.NoiDungKhenThuongMemoEdit.Location = new System.Drawing.Point(76, 84);
            this.NoiDungKhenThuongMemoEdit.MenuManager = this.BM;
            this.NoiDungKhenThuongMemoEdit.Name = "NoiDungKhenThuongMemoEdit";
            this.NoiDungKhenThuongMemoEdit.Size = new System.Drawing.Size(396, 75);
            this.NoiDungKhenThuongMemoEdit.StyleController = this.dataLayoutControl1;
            this.NoiDungKhenThuongMemoEdit.TabIndex = 6;
            // 
            // NgayKhenThuongDateEdit
            // 
            this.NgayKhenThuongDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpcKhenThuong, "NgayKhenThuong", true));
            this.NgayKhenThuongDateEdit.EditValue = null;
            this.NgayKhenThuongDateEdit.Location = new System.Drawing.Point(308, 60);
            this.NgayKhenThuongDateEdit.MenuManager = this.BM;
            this.NgayKhenThuongDateEdit.Name = "NgayKhenThuongDateEdit";
            this.NgayKhenThuongDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayKhenThuongDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayKhenThuongDateEdit.Size = new System.Drawing.Size(164, 20);
            this.NgayKhenThuongDateEdit.StyleController = this.dataLayoutControl1;
            this.NgayKhenThuongDateEdit.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(484, 173);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForNoiDungKhenThuong,
            this.ItemForNgayKhenThuong,
            this.layoutControlItem3,
            this.simpleSeparator1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(464, 153);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NhanSuSLK;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "ItemForNhanSu!Key";
            this.layoutControlItem1.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItem1.Text = "Nhân sự";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.HinhThucKhenThuongSLK;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "ItemForHinhThucKhenThuong!Key";
            this.layoutControlItem2.Size = new System.Drawing.Size(232, 24);
            this.layoutControlItem2.Text = "Hình thức KT";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForNoiDungKhenThuong
            // 
            this.ItemForNoiDungKhenThuong.Control = this.NoiDungKhenThuongMemoEdit;
            this.ItemForNoiDungKhenThuong.Location = new System.Drawing.Point(0, 72);
            this.ItemForNoiDungKhenThuong.Name = "ItemForNoiDungKhenThuong";
            this.ItemForNoiDungKhenThuong.Size = new System.Drawing.Size(464, 79);
            this.ItemForNoiDungKhenThuong.StartNewLine = true;
            this.ItemForNoiDungKhenThuong.Text = "Nội dung KT";
            this.ItemForNoiDungKhenThuong.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForNgayKhenThuong
            // 
            this.ItemForNgayKhenThuong.Control = this.NgayKhenThuongDateEdit;
            this.ItemForNgayKhenThuong.Location = new System.Drawing.Point(232, 48);
            this.ItemForNgayKhenThuong.Name = "ItemForNgayKhenThuong";
            this.ItemForNgayKhenThuong.Size = new System.Drawing.Size(232, 24);
            this.ItemForNgayKhenThuong.Text = "Ngày KT";
            this.ItemForNgayKhenThuong.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.DonViSLK;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItem3.Text = "Đơn vị";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 151);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(464, 2);
            // 
            // btnLuuVaThem
            // 
            this.btnLuuVaThem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnLuuVaThem.Caption = "Lưu và thêm";
            this.btnLuuVaThem.Id = 8;
            this.btnLuuVaThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuVaThem.ImageOptions.Image")));
            this.btnLuuVaThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuVaThem.ImageOptions.LargeImage")));
            this.btnLuuVaThem.Name = "btnLuuVaThem";
            this.btnLuuVaThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuVaThem_ItemClick);
            // 
            // FrmKhenThuongDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 202);
            this.Controls.Add(this.dataLayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKhenThuongDialog";
            this.Text = "FrmKhenThuongDialog";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DonViSLK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanSuSLK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhThucKhenThuongSLK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcHinhThucKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiDungKhenThuongMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKhenThuongDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKhenThuongDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiDungKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgayKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError;
        private DevExpress.Xpo.XPCollection xpcKhenThuong;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit NhanSuSLK;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit HinhThucKhenThuongSLK;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.MemoEdit NoiDungKhenThuongMemoEdit;
        private DevExpress.XtraEditors.DateEdit NgayKhenThuongDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoiDungKhenThuong;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNgayKhenThuong;
        private DevExpress.XtraEditors.SearchLookUpEdit DonViSLK;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Xpo.XPCollection xpcDonVi;
        private DevExpress.Xpo.XPCollection xpcNhanSu;
        private DevExpress.Xpo.XPCollection xpcHinhThucKhenThuong;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaThem;
    }
}