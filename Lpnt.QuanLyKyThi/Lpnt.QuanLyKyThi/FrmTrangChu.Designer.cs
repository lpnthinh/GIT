namespace Lpnt.QuanLyKyThi
{
    partial class FrmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RS = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DM = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.rpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpHoTro = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnKetNoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.rpgTienIch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGiaiPhongBoNho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongTatCaTab = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaUngDung = new DevExpress.XtraBars.BarButtonItem();
            this.itemCoSoDuLieu = new DevExpress.XtraBars.BarStaticItem();
            this.itemGiaoDien = new DevExpress.XtraBars.BarStaticItem();
            this.itemNgay = new DevExpress.XtraBars.BarStaticItem();
            this.itemPhienBan = new DevExpress.XtraBars.BarStaticItem();
            this.itemNhomNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            this.itemNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            this.itemNamHoc = new DevExpress.XtraBars.BarStaticItem();
            this.IMC = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMC)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.btnKetNoi,
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.btnDoiMatKhau,
            this.btnGiaiPhongBoNho,
            this.btnDongTatCaTab,
            this.btnKhoaUngDung,
            this.itemCoSoDuLieu,
            this.itemGiaoDien,
            this.itemNgay,
            this.itemPhienBan,
            this.itemNhomNguoiDung,
            this.itemNguoiDung,
            this.itemNamHoc});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnDongTatCaTab);
            this.ribbon.PageHeaderItemLinks.Add(this.btnKhoaUngDung);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHeThong,
            this.rpNghiepVu,
            this.rpHoTro});
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNhomNguoiDung);
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNguoiDung, true);
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(758, 144);
            this.ribbon.StatusBar = this.RS;
            // 
            // rpHeThong
            // 
            this.rpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpgGiaoDien,
            this.ribbonPageGroup4,
            this.rpgTienIch});
            this.rpHeThong.Name = "rpHeThong";
            this.rpHeThong.Text = "Hệ thống";
            // 
            // rpgGiaoDien
            // 
            this.rpgGiaoDien.AllowTextClipping = false;
            this.rpgGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rpgGiaoDien.Name = "rpgGiaoDien";
            this.rpgGiaoDien.ShowCaptionButton = false;
            this.rpgGiaoDien.Text = "Giao diện";
            // 
            // RS
            // 
            this.RS.ItemLinks.Add(this.itemCoSoDuLieu);
            this.RS.ItemLinks.Add(this.itemGiaoDien);
            this.RS.ItemLinks.Add(this.itemNgay, true);
            this.RS.ItemLinks.Add(this.itemPhienBan, true);
            this.RS.ItemLinks.Add(this.itemNamHoc, true);
            this.RS.Location = new System.Drawing.Point(0, 328);
            this.RS.Name = "RS";
            this.RS.Ribbon = this.ribbon;
            this.RS.Size = new System.Drawing.Size(758, 32);
            // 
            // DM
            // 
            this.DM.MdiParent = this;
            this.DM.MenuManager = this.ribbon;
            this.DM.View = this.tabbedView1;
            this.DM.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // rpNghiepVu
            // 
            this.rpNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpNghiepVu.Name = "rpNghiepVu";
            this.rpNghiepVu.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // rpHoTro
            // 
            this.rpHoTro.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rpHoTro.Name = "rpHoTro";
            this.rpHoTro.Text = "Hỗ trợ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKetNoi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaoLuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhucHoi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Cơ sở dữ liệu";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Caption = "Kết nối";
            this.btnKetNoi.Id = 2;
            this.btnKetNoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.ImageOptions.Image")));
            this.btnKetNoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.ImageOptions.LargeImage")));
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKetNoi_ItemClick);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 3;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Người dùng";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 5;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // rpgTienIch
            // 
            this.rpgTienIch.AllowTextClipping = false;
            this.rpgTienIch.ItemLinks.Add(this.btnGiaiPhongBoNho);
            this.rpgTienIch.Name = "rpgTienIch";
            this.rpgTienIch.ShowCaptionButton = false;
            this.rpgTienIch.Text = "Tiện ích";
            // 
            // btnGiaiPhongBoNho
            // 
            this.btnGiaiPhongBoNho.Caption = "Giải phóng bộ nhớ";
            this.btnGiaiPhongBoNho.Id = 6;
            this.btnGiaiPhongBoNho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaiPhongBoNho.ImageOptions.Image")));
            this.btnGiaiPhongBoNho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaiPhongBoNho.ImageOptions.LargeImage")));
            this.btnGiaiPhongBoNho.Name = "btnGiaiPhongBoNho";
            this.btnGiaiPhongBoNho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaiPhongBoNho_ItemClick);
            // 
            // btnDongTatCaTab
            // 
            this.btnDongTatCaTab.Caption = "Đóng tất cả Tabpage đang mở";
            this.btnDongTatCaTab.Id = 7;
            this.btnDongTatCaTab.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongTatCaTab.ImageOptions.Image")));
            this.btnDongTatCaTab.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongTatCaTab.ImageOptions.LargeImage")));
            this.btnDongTatCaTab.Name = "btnDongTatCaTab";
            this.btnDongTatCaTab.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongTatCaTab_ItemClick);
            // 
            // btnKhoaUngDung
            // 
            this.btnKhoaUngDung.Caption = "Khóa ứng dụng";
            this.btnKhoaUngDung.Id = 8;
            this.btnKhoaUngDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoaUngDung.ImageOptions.Image")));
            this.btnKhoaUngDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhoaUngDung.ImageOptions.LargeImage")));
            this.btnKhoaUngDung.Name = "btnKhoaUngDung";
            this.btnKhoaUngDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoaUngDung_ItemClick);
            // 
            // itemCoSoDuLieu
            // 
            this.itemCoSoDuLieu.Caption = "Cơ sở dữ liệu";
            this.itemCoSoDuLieu.Id = 9;
            this.itemCoSoDuLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemCoSoDuLieu.ImageOptions.Image")));
            this.itemCoSoDuLieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemCoSoDuLieu.ImageOptions.LargeImage")));
            this.itemCoSoDuLieu.Name = "itemCoSoDuLieu";
            this.itemCoSoDuLieu.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemGiaoDien
            // 
            this.itemGiaoDien.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemGiaoDien.Caption = "Giao diện";
            this.itemGiaoDien.Id = 10;
            this.itemGiaoDien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemGiaoDien.ImageOptions.Image")));
            this.itemGiaoDien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemGiaoDien.ImageOptions.LargeImage")));
            this.itemGiaoDien.Name = "itemGiaoDien";
            this.itemGiaoDien.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNgay
            // 
            this.itemNgay.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemNgay.Caption = "Ngày";
            this.itemNgay.Id = 11;
            this.itemNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNgay.ImageOptions.Image")));
            this.itemNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNgay.ImageOptions.LargeImage")));
            this.itemNgay.Name = "itemNgay";
            this.itemNgay.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemPhienBan
            // 
            this.itemPhienBan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemPhienBan.Caption = "Phiên bản";
            this.itemPhienBan.Id = 12;
            this.itemPhienBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemPhienBan.ImageOptions.Image")));
            this.itemPhienBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemPhienBan.ImageOptions.LargeImage")));
            this.itemPhienBan.Name = "itemPhienBan";
            this.itemPhienBan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNhomNguoiDung
            // 
            this.itemNhomNguoiDung.Caption = "[Nhóm người dùng]";
            this.itemNhomNguoiDung.Id = 13;
            this.itemNhomNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNhomNguoiDung.ImageOptions.Image")));
            this.itemNhomNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNhomNguoiDung.ImageOptions.LargeImage")));
            this.itemNhomNguoiDung.Name = "itemNhomNguoiDung";
            this.itemNhomNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNguoiDung
            // 
            this.itemNguoiDung.Caption = "[Người dùng]";
            this.itemNguoiDung.Id = 14;
            this.itemNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNguoiDung.ImageOptions.Image")));
            this.itemNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNguoiDung.ImageOptions.LargeImage")));
            this.itemNguoiDung.Name = "itemNguoiDung";
            this.itemNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNamHoc
            // 
            this.itemNamHoc.Caption = "Năm học";
            this.itemNamHoc.Id = 15;
            this.itemNamHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNamHoc.ImageOptions.Image")));
            this.itemNamHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNamHoc.ImageOptions.LargeImage")));
            this.itemNamHoc.Name = "itemNamHoc";
            this.itemNamHoc.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // IMC
            // 
            this.IMC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMC.ImageStream")));
            this.IMC.InsertGalleryImage("publicfix_16x16.png", "office2013/people/publicfix_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/publicfix_16x16.png"), 0);
            this.IMC.Images.SetKeyName(0, "publicfix_16x16.png");
            this.IMC.InsertGalleryImage("assigntome_16x16.png", "office2013/people/assigntome_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/assigntome_16x16.png"), 1);
            this.IMC.Images.SetKeyName(1, "assigntome_16x16.png");
            this.IMC.InsertGalleryImage("publicfix_16x16.png", "images/people/publicfix_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/publicfix_16x16.png"), 2);
            this.IMC.Images.SetKeyName(2, "publicfix_16x16.png");
            this.IMC.InsertGalleryImage("user_16x16.png", "images/people/user_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/user_16x16.png"), 3);
            this.IMC.Images.SetKeyName(3, "user_16x16.png");
            // 
            // FrmTrangChu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.RS);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmTrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.RS;
            this.Text = "Phần mềm quản lý kỳ thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGiaoDien;
        private DevExpress.XtraBars.Docking2010.DocumentManager DM;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar RS;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHoTro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKetNoi;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnGiaiPhongBoNho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTienIch;
        private DevExpress.XtraBars.BarButtonItem btnDongTatCaTab;
        private DevExpress.XtraBars.BarButtonItem btnKhoaUngDung;
        private DevExpress.XtraBars.BarStaticItem itemCoSoDuLieu;
        private DevExpress.XtraBars.BarStaticItem itemGiaoDien;
        private DevExpress.XtraBars.BarStaticItem itemNgay;
        private DevExpress.XtraBars.BarStaticItem itemPhienBan;
        private DevExpress.XtraBars.BarStaticItem itemNhomNguoiDung;
        private DevExpress.XtraBars.BarStaticItem itemNguoiDung;
        private DevExpress.XtraBars.BarStaticItem itemNamHoc;
        private DevExpress.Utils.ImageCollection IMC;
    }
}

