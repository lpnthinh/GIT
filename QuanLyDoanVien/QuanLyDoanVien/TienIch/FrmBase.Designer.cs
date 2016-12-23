namespace QuanLyDoanVien.TienIch
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.BM = new DevExpress.XtraBars.BarManager(this.components);
            this.TB = new DevExpress.XtraBars.Bar();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemVaIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // BM
            // 
            this.BM.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.TB});
            this.BM.DockControls.Add(this.barDockControlTop);
            this.BM.DockControls.Add(this.barDockControlBottom);
            this.BM.DockControls.Add(this.barDockControlLeft);
            this.BM.DockControls.Add(this.barDockControlRight);
            this.BM.Form = this;
            this.BM.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNap,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnDong,
            this.btnXuatExcel,
            this.btnXemVaIn});
            this.BM.MaxItemId = 8;
            // 
            // TB
            // 
            this.TB.BarName = "Tools";
            this.TB.DockCol = 0;
            this.TB.DockRow = 0;
            this.TB.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawDragBorder = false;
            this.TB.OptionsBar.UseWholeRow = true;
            this.TB.Text = "Tools";
            // 
            // btnNap
            // 
            this.btnNap.Caption = "Nạp (F5)";
            this.btnNap.Id = 0;
            this.btnNap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.Image")));
            this.btnNap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.LargeImage")));
            this.btnNap.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnNap.Name = "btnNap";
            this.btnNap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNap_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnXuatExcel.Caption = "Xuất Excel";
            this.btnXuatExcel.Id = 6;
            this.btnXuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.Image")));
            this.btnXuatExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.LargeImage")));
            this.btnXuatExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.E));
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatExcel_ItemClick);
            // 
            // btnXemVaIn
            // 
            this.btnXemVaIn.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnXemVaIn.Caption = "Xem và in";
            this.btnXemVaIn.Id = 7;
            this.btnXemVaIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.Image")));
            this.btnXemVaIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.LargeImage")));
            this.btnXemVaIn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnXemVaIn.Name = "btnXemVaIn";
            this.btnXemVaIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemVaIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BM;
            this.barDockControlTop.Size = new System.Drawing.Size(584, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 362);
            this.barDockControlBottom.Manager = this.BM;
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.BM;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 25);
            this.barDockControlRight.Manager = this.BM;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.Activated += new System.EventHandler(this.FrmBase_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.Xpo.UnitOfWork UOW;
        protected DevExpress.XtraBars.BarManager BM;
        protected DevExpress.XtraBars.Bar TB;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarButtonItem btnThem;
        protected DevExpress.XtraBars.BarButtonItem btnSua;
        protected DevExpress.XtraBars.BarButtonItem btnXoa;
        protected DevExpress.XtraBars.BarButtonItem btnLuu;
        protected DevExpress.XtraBars.BarButtonItem btnDong;
        protected DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        protected DevExpress.XtraBars.BarButtonItem btnXemVaIn;
        protected DevExpress.XtraBars.BarButtonItem btnNap;
    }
}