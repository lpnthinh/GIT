namespace QuanLyDoanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DM = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.itemCoSoDuLieu = new DevExpress.XtraBars.BarStaticItem();
            this.itemGiaoDien = new DevExpress.XtraBars.BarStaticItem();
            this.itemNgay = new DevExpress.XtraBars.BarStaticItem();
            this.itemPhienBan = new DevExpress.XtraBars.BarStaticItem();
            this.itemThietKe = new DevExpress.XtraBars.BarStaticItem();
            this.btnDongTatCaTab = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaUngDung = new DevExpress.XtraBars.BarButtonItem();
            this.itemNhomNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            this.itemNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            this.lblNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.itemCoSoDuLieu,
            this.itemGiaoDien,
            this.itemNgay,
            this.itemPhienBan,
            this.itemThietKe,
            this.btnDongTatCaTab,
            this.btnKhoaUngDung,
            this.itemNhomNguoiDung,
            this.itemNguoiDung,
            this.lblNguoiDung});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnDongTatCaTab);
            this.ribbon.PageHeaderItemLinks.Add(this.btnKhoaUngDung);
            this.ribbon.PageHeaderItemLinks.Add(this.lblNguoiDung);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHeThong});
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNhomNguoiDung);
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNguoiDung, true);
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(758, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            // 
            // rpHeThong
            // 
            this.rpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgGiaoDien});
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
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.itemThietKe);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemCoSoDuLieu, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemGiaoDien);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemNgay, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemPhienBan, true);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 328);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(758, 32);
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
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // itemCoSoDuLieu
            // 
            this.itemCoSoDuLieu.Caption = "CSDL";
            this.itemCoSoDuLieu.Id = 2;
            this.itemCoSoDuLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemCoSoDuLieu.ImageOptions.Image")));
            this.itemCoSoDuLieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemCoSoDuLieu.ImageOptions.LargeImage")));
            this.itemCoSoDuLieu.Name = "itemCoSoDuLieu";
            this.itemCoSoDuLieu.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemGiaoDien
            // 
            this.itemGiaoDien.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemGiaoDien.Caption = "Giao diện";
            this.itemGiaoDien.Id = 3;
            this.itemGiaoDien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemGiaoDien.ImageOptions.Image")));
            this.itemGiaoDien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemGiaoDien.ImageOptions.LargeImage")));
            this.itemGiaoDien.Name = "itemGiaoDien";
            this.itemGiaoDien.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNgay
            // 
            this.itemNgay.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemNgay.Caption = "Ngày";
            this.itemNgay.Id = 4;
            this.itemNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNgay.ImageOptions.Image")));
            this.itemNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNgay.ImageOptions.LargeImage")));
            this.itemNgay.Name = "itemNgay";
            this.itemNgay.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemPhienBan
            // 
            this.itemPhienBan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemPhienBan.Caption = "Phiên bản";
            this.itemPhienBan.Id = 5;
            this.itemPhienBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemPhienBan.ImageOptions.Image")));
            this.itemPhienBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemPhienBan.ImageOptions.LargeImage")));
            this.itemPhienBan.Name = "itemPhienBan";
            this.itemPhienBan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemThietKe
            // 
            this.itemThietKe.Caption = "Thiết kế bởi [lpnt]";
            this.itemThietKe.Id = 6;
            this.itemThietKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemThietKe.ImageOptions.Image")));
            this.itemThietKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemThietKe.ImageOptions.LargeImage")));
            this.itemThietKe.Name = "itemThietKe";
            this.itemThietKe.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnDongTatCaTab
            // 
            this.btnDongTatCaTab.Caption = "Đóng tất cả Tab đang mở";
            this.btnDongTatCaTab.Id = 7;
            this.btnDongTatCaTab.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongTatCaTab.ImageOptions.Image")));
            this.btnDongTatCaTab.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongTatCaTab.ImageOptions.LargeImage")));
            this.btnDongTatCaTab.Name = "btnDongTatCaTab";
            // 
            // btnKhoaUngDung
            // 
            this.btnKhoaUngDung.Caption = "Khóa ứng dụng";
            this.btnKhoaUngDung.Id = 8;
            this.btnKhoaUngDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoaUngDung.ImageOptions.Image")));
            this.btnKhoaUngDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhoaUngDung.ImageOptions.LargeImage")));
            this.btnKhoaUngDung.Name = "btnKhoaUngDung";
            // 
            // itemNhomNguoiDung
            // 
            this.itemNhomNguoiDung.Caption = "Nhóm";
            this.itemNhomNguoiDung.Id = 9;
            this.itemNhomNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNhomNguoiDung.ImageOptions.Image")));
            this.itemNhomNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNhomNguoiDung.ImageOptions.LargeImage")));
            this.itemNhomNguoiDung.Name = "itemNhomNguoiDung";
            this.itemNhomNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNguoiDung
            // 
            this.itemNguoiDung.Caption = "Người dùng";
            this.itemNguoiDung.Id = 10;
            this.itemNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNguoiDung.ImageOptions.Image")));
            this.itemNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNguoiDung.ImageOptions.LargeImage")));
            this.itemNguoiDung.Name = "itemNguoiDung";
            this.itemNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Caption = "Đăng nhập!";
            this.lblNguoiDung.Id = 11;
            this.lblNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblNguoiDung.ImageOptions.Image")));
            this.lblNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("lblNguoiDung.ImageOptions.LargeImage")));
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // FrmTrangChu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmTrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý đoàn viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGiaoDien;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Docking2010.DocumentManager DM;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarStaticItem itemCoSoDuLieu;
        private DevExpress.XtraBars.BarStaticItem itemGiaoDien;
        private DevExpress.XtraBars.BarStaticItem itemNgay;
        private DevExpress.XtraBars.BarStaticItem itemPhienBan;
        private DevExpress.XtraBars.BarStaticItem itemThietKe;
        private DevExpress.XtraBars.BarButtonItem btnDongTatCaTab;
        private DevExpress.XtraBars.BarButtonItem btnKhoaUngDung;
        private DevExpress.XtraBars.BarStaticItem itemNhomNguoiDung;
        private DevExpress.XtraBars.BarStaticItem itemNguoiDung;
        private DevExpress.XtraBars.BarStaticItem lblNguoiDung;
    }
}

