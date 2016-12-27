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
            this.btnGiaiPhongBoNho = new DevExpress.XtraBars.BarButtonItem();
            this.btnKetNoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.itemNienKhoa = new DevExpress.XtraBars.BarStaticItem();
            this.btnNienKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThamSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnHanhChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonVi = new DevExpress.XtraBars.BarButtonItem();
            this.rpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgCoSoDuLieu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgCauHinh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTienIch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgNguoiDung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgHoTich = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpHoTro = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DM = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.IMC = new DevExpress.Utils.ImageCollection(this.components);
            this.btnNhapTuExcel = new DevExpress.XtraBars.BarButtonItem();
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
            this.itemCoSoDuLieu,
            this.itemGiaoDien,
            this.itemNgay,
            this.itemPhienBan,
            this.itemThietKe,
            this.btnDongTatCaTab,
            this.btnKhoaUngDung,
            this.itemNhomNguoiDung,
            this.itemNguoiDung,
            this.lblNguoiDung,
            this.btnGiaiPhongBoNho,
            this.btnKetNoi,
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.btnDoiMatKhau,
            this.itemNienKhoa,
            this.btnNienKhoa,
            this.btnThamSo,
            this.btnHanhChinh,
            this.btnPhanQuyen,
            this.btnDonVi,
            this.btnNhapTuExcel});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnDongTatCaTab);
            this.ribbon.PageHeaderItemLinks.Add(this.btnKhoaUngDung);
            this.ribbon.PageHeaderItemLinks.Add(this.lblNguoiDung);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHeThong,
            this.rpDanhMuc,
            this.rpNghiepVu,
            this.rpHoTro});
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNhomNguoiDung);
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNguoiDung, true);
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(758, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
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
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnGiaiPhongBoNho
            // 
            this.btnGiaiPhongBoNho.Caption = "Giải phóng bộ nhớ";
            this.btnGiaiPhongBoNho.Id = 12;
            this.btnGiaiPhongBoNho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaiPhongBoNho.ImageOptions.Image")));
            this.btnGiaiPhongBoNho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaiPhongBoNho.ImageOptions.LargeImage")));
            this.btnGiaiPhongBoNho.Name = "btnGiaiPhongBoNho";
            this.btnGiaiPhongBoNho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaiPhongBoNho_ItemClick);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Caption = "Kết nối";
            this.btnKetNoi.Id = 13;
            this.btnKetNoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.ImageOptions.Image")));
            this.btnKetNoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.ImageOptions.LargeImage")));
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKetNoi_ItemClick);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 14;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 15;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 16;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // itemNienKhoa
            // 
            this.itemNienKhoa.Caption = "Niên khóa";
            this.itemNienKhoa.Id = 17;
            this.itemNienKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNienKhoa.ImageOptions.Image")));
            this.itemNienKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemNienKhoa.ImageOptions.LargeImage")));
            this.itemNienKhoa.Name = "itemNienKhoa";
            this.itemNienKhoa.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnNienKhoa
            // 
            this.btnNienKhoa.Caption = "Niên khóa";
            this.btnNienKhoa.Id = 18;
            this.btnNienKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNienKhoa.ImageOptions.Image")));
            this.btnNienKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNienKhoa.ImageOptions.LargeImage")));
            this.btnNienKhoa.Name = "btnNienKhoa";
            this.btnNienKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNienKhoa_ItemClick);
            // 
            // btnThamSo
            // 
            this.btnThamSo.Caption = "Tham số";
            this.btnThamSo.Id = 20;
            this.btnThamSo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThamSo.ImageOptions.Image")));
            this.btnThamSo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThamSo.ImageOptions.LargeImage")));
            this.btnThamSo.Name = "btnThamSo";
            this.btnThamSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThamSo_ItemClick);
            // 
            // btnHanhChinh
            // 
            this.btnHanhChinh.Caption = "Hành chính";
            this.btnHanhChinh.Id = 21;
            this.btnHanhChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHanhChinh.ImageOptions.Image")));
            this.btnHanhChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHanhChinh.ImageOptions.LargeImage")));
            this.btnHanhChinh.Name = "btnHanhChinh";
            this.btnHanhChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHanhChinh_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền";
            this.btnPhanQuyen.Id = 22;
            this.btnPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.Image")));
            this.btnPhanQuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.LargeImage")));
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnDonVi
            // 
            this.btnDonVi.Caption = "Đơn vị";
            this.btnDonVi.Id = 23;
            this.btnDonVi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonVi.ImageOptions.Image")));
            this.btnDonVi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDonVi.ImageOptions.LargeImage")));
            this.btnDonVi.Name = "btnDonVi";
            this.btnDonVi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonVi_ItemClick);
            // 
            // rpHeThong
            // 
            this.rpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgCoSoDuLieu,
            this.rpgCauHinh,
            this.rpgTienIch,
            this.rpgNguoiDung,
            this.rpgGiaoDien});
            this.rpHeThong.Name = "rpHeThong";
            this.rpHeThong.Text = "Hệ thống";
            // 
            // rpgCoSoDuLieu
            // 
            this.rpgCoSoDuLieu.AllowTextClipping = false;
            this.rpgCoSoDuLieu.ItemLinks.Add(this.btnKetNoi);
            this.rpgCoSoDuLieu.ItemLinks.Add(this.btnSaoLuu);
            this.rpgCoSoDuLieu.ItemLinks.Add(this.btnPhucHoi);
            this.rpgCoSoDuLieu.Name = "rpgCoSoDuLieu";
            this.rpgCoSoDuLieu.ShowCaptionButton = false;
            this.rpgCoSoDuLieu.Text = "Cơ sở dữ liệu";
            // 
            // rpgCauHinh
            // 
            this.rpgCauHinh.AllowTextClipping = false;
            this.rpgCauHinh.ItemLinks.Add(this.btnThamSo);
            this.rpgCauHinh.Name = "rpgCauHinh";
            this.rpgCauHinh.ShowCaptionButton = false;
            this.rpgCauHinh.Text = "Cấu hình";
            // 
            // rpgTienIch
            // 
            this.rpgTienIch.AllowTextClipping = false;
            this.rpgTienIch.ItemLinks.Add(this.btnGiaiPhongBoNho);
            this.rpgTienIch.ItemLinks.Add(this.btnNhapTuExcel);
            this.rpgTienIch.Name = "rpgTienIch";
            this.rpgTienIch.ShowCaptionButton = false;
            this.rpgTienIch.Text = "Tiện ích";
            // 
            // rpgNguoiDung
            // 
            this.rpgNguoiDung.AllowTextClipping = false;
            this.rpgNguoiDung.ItemLinks.Add(this.btnDoiMatKhau);
            this.rpgNguoiDung.ItemLinks.Add(this.btnPhanQuyen);
            this.rpgNguoiDung.Name = "rpgNguoiDung";
            this.rpgNguoiDung.ShowCaptionButton = false;
            this.rpgNguoiDung.Text = "Người dùng";
            // 
            // rpgGiaoDien
            // 
            this.rpgGiaoDien.AllowTextClipping = false;
            this.rpgGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rpgGiaoDien.Name = "rpgGiaoDien";
            this.rpgGiaoDien.ShowCaptionButton = false;
            this.rpgGiaoDien.Text = "Giao diện";
            // 
            // rpDanhMuc
            // 
            this.rpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHoTich});
            this.rpDanhMuc.Name = "rpDanhMuc";
            this.rpDanhMuc.Text = "Danh mục";
            // 
            // rpgHoTich
            // 
            this.rpgHoTich.AllowTextClipping = false;
            this.rpgHoTich.ItemLinks.Add(this.btnHanhChinh);
            this.rpgHoTich.Name = "rpgHoTich";
            this.rpgHoTich.ShowCaptionButton = false;
            this.rpgHoTich.Text = "Hộ tịch";
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
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNienKhoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonVi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Đối tượng";
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
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.itemThietKe);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemCoSoDuLieu, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemGiaoDien);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemNgay, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemPhienBan, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemNienKhoa, true);
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
            // IMC
            // 
            this.IMC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMC.ImageStream")));
            this.IMC.InsertGalleryImage("assignto_16x16.png", "office2013/people/assignto_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/assignto_16x16.png"), 0);
            this.IMC.Images.SetKeyName(0, "assignto_16x16.png");
            this.IMC.InsertGalleryImage("bodetails_16x16.png", "images/business%20objects/bodetails_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bodetails_16x16.png"), 1);
            this.IMC.Images.SetKeyName(1, "bodetails_16x16.png");
            // 
            // btnNhapTuExcel
            // 
            this.btnNhapTuExcel.Caption = "Nhập từ Excel";
            this.btnNhapTuExcel.Id = 24;
            this.btnNhapTuExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapTuExcel.ImageOptions.Image")));
            this.btnNhapTuExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapTuExcel.ImageOptions.LargeImage")));
            this.btnNhapTuExcel.Name = "btnNhapTuExcel";
            this.btnNhapTuExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapTuExcel_ItemClick);
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
        private DevExpress.XtraBars.BarButtonItem btnGiaiPhongBoNho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTienIch;
        private DevExpress.XtraBars.BarButtonItem btnKetNoi;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCoSoDuLieu;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNguoiDung;
        private DevExpress.XtraBars.BarStaticItem itemNienKhoa;
        private DevExpress.Utils.ImageCollection IMC;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHoTich;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHoTro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnNienKhoa;
        private DevExpress.XtraBars.BarButtonItem btnThamSo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCauHinh;
        private DevExpress.XtraBars.BarButtonItem btnHanhChinh;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnDonVi;
        private DevExpress.XtraBars.BarButtonItem btnNhapTuExcel;
    }
}

