using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using QuanLyDoanVien.DanhMuc;
using QuanLyDoanVien.DuLieu;
using QuanLyDoanVien.HeThong;
using QuanLyDoanVien.NghiepVu;
using QuanLyDoanVien.NghiepVu.QLVanBan;
using QuanLyDoanVien.TienIch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDoanVien
{
    public partial class FrmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmTrangChu()
        {
            InitializeComponent();

            itemNgay.Caption = string.Format("Ngày: {0:dd/MM/yyyy}", DateTime.Today);

            NapTatCaThongTin();
        }
        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            DangNhap();
        }
        private void FrmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBox.ShowYesNoDialog("Bạn có chắc muốn thoát chương trình?") == DialogResult.No)
                e.Cancel = true;
        }
        public void NapTatCaThongTin()
        {
            NapGiaoDien();
            NapCoSoDuLieu();
            NapPhienBan();
        }
        public void NapGiaoDien()
        {
            string defaultSkin = "Office 2010 Blue";
            UserLookAndFeel.Default.SetSkinStyle(defaultSkin);
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);

            object tmp;
            Param.GetValue("Giao diện", out tmp, ParamCategory.UserConfig, defaultSkin, DataType.String);

            defaultSkin = tmp.ToString();
            itemGiaoDien.Caption = string.Format("Giao diện: {0}", defaultSkin);
            UserLookAndFeel.Default.SkinName = defaultSkin;
        }
        private void Default_StyleChanged(object sender, EventArgs e)
        {
            itemGiaoDien.Caption = string.Format("Giao diện: {0}", UserLookAndFeel.Default.SkinName);
            Param.SetValue("Giao diện", UserLookAndFeel.Default.SkinName);
            AppConfig.SetValue("Skin", UserLookAndFeel.Default.SkinName);
        }
        public void NapCoSoDuLieu()
        {
            itemCoSoDuLieu.Caption = AppConfig.GetValue("Database");
        }
        public void NapPhienBan()
        {
            itemPhienBan.Caption = string.Format("Phiên bản: {0}", Application.ProductVersion);
        }
        public void NapNienKhoa()
        {
            itemNienKhoa.Caption = "Niên khóa";

            XpoDefault.Session.Disconnect();
            XpoDefault.Session.Connect();

            var nienkhoa = NienKhoa.FindObject<NienKhoa>("SuDung", true);
            if (nienkhoa != null)
            {
                itemNienKhoa.Caption = string.Format("Niên khóa: {0}", nienkhoa.Ten);
                clsHeThong.NienKhoaSuDung = nienkhoa;
            }
        }
        private void OpenForm<T>()
        {
            PhanQuyen p = PhanQuyen.Find(clsDuLieu.NguoiDungDangNhap.Nhom, clsHeThong.ChucNangDangChon);
            if (p == null) return;
            if (!p.TruyCap)
            {
                MsgBox.ShowWarningDialog("Bạn không có quyền truy cập chức năng này");
                return;
            }
            MsgBox.ShowWaitForm();
            var f = MdiChildren.FirstOrDefault(i => i is T);
            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                f.MdiParent = this;
                f.Show();
            }
            else f.Activate();
            MsgBox.CloseWaitForm();
        }
        private void OpenForm<T>(object arg, string name) where T : Form
        {
            PhanQuyen p = PhanQuyen.Find(clsDuLieu.NguoiDungDangNhap.Nhom, clsHeThong.ChucNangDangChon);
            if (p == null) return;
            if (!p.TruyCap)
            {
                MsgBox.ShowWarningDialog("Bạn không có quyền truy cập chức năng này");
                return;
            }

            MsgBox.ShowWaitForm();
            var f = MdiChildren.FirstOrDefault(i => i.Name.Equals(name));
            if (f == null)
            {
                f = Activator.CreateInstance(typeof(T), arg) as T;
                f.MdiParent = this;
                f.Name = name;
                f.Show();
            }
            else f.Activate();
            MsgBox.CloseWaitForm();
        }
        private void DangNhap()
        {
            foreach (Form f in MdiChildren)
                f.Close();
            if (MdiChildren.Length > 0) return;

            XpoDefault.Session.Disconnect();
            XpoDefault.Session.Connect();
            clsDuLieu.NguoiDungDangNhap = null;


            lblNguoiDung.ImageOptions.Image = IMC.Images[0];
            lblNguoiDung.Caption = "Đăng nhập!";
            itemNhomNguoiDung.Caption = "Nhóm người dùng";
            itemNguoiDung.Caption = "Người dùng";

            var fDangNhap = new FrmDangNhap();
            if (fDangNhap.ShowDialog() == DialogResult.OK)
            {
                #region KIỂM TRA QUYỀN ĐĂNG NHẬP
                foreach (RibbonPage page in ribbon.Pages)
                {
                    if (page.Equals(rpHoTro)) continue;

                    var chucnangPage = ChucNang.FindObject<ChucNang>("Ma", page.Name);
                    if (chucnangPage == null)
                    {
                        chucnangPage = new ChucNang(XpoDefault.Session);
                        chucnangPage.Ma = page.Name;
                    }
                    chucnangPage.Ten = page.Text;
                    chucnangPage.Save();

                    foreach (RibbonPageGroup group in page.Groups)
                    {
                        if (group.Equals(rpgGiaoDien)) continue;

                        var chucnangGroup = ChucNang.FindObject<ChucNang>("Ma", group.Name);
                        if (chucnangGroup == null)
                        {
                            chucnangGroup = new ChucNang(XpoDefault.Session);
                            chucnangGroup.Ma = group.Name;
                            chucnangGroup.Cha = chucnangPage;
                        }
                        chucnangGroup.Ten = group.Text;
                        chucnangGroup.Save();

                        foreach (BarItemLink itemlink in group.ItemLinks)
                        {
                            if (itemlink.Item.Equals(btnKhoaUngDung)) continue;
                            if (itemlink.Item.Equals(btnDoiMatKhau)) continue;
                            if (itemlink.Item.Equals(btnGiaiPhongBoNho)) continue;

                            var chucnangItem = ChucNang.FindObject<ChucNang>("Ma", itemlink.Item.Name);
                            if (chucnangItem == null)
                            {
                                chucnangItem = new ChucNang(XpoDefault.Session);
                                chucnangItem.Ma = itemlink.Item.Name;
                                chucnangItem.Cha = chucnangGroup;
                            }
                            chucnangItem.Ten = itemlink.Caption;
                            if (string.IsNullOrEmpty(group.Text))
                            {
                                chucnangItem.Cha = chucnangPage;
                            }

                            chucnangItem.Save();

                            itemlink.Item.Tag = chucnangItem;

                            if (clsDuLieu.NguoiDungDangNhap != null)
                            {
                                var quyenItem = PhanQuyen.FindAndNew(null, clsDuLieu.NguoiDungDangNhap.Nhom, chucnangItem);
                                itemlink.Item.Enabled = quyenItem.TruyCap;
                            }

                            // CHEAT NGƯỜI DÙNG HỆ THỐNG
                            if (clsDuLieu.NguoiDungDangNhap == null)
                                itemlink.Item.Enabled = true;
                        }
                        if (clsDuLieu.NguoiDungDangNhap != null)
                            PhanQuyen.FindAndNew(null, clsDuLieu.NguoiDungDangNhap.Nhom, chucnangGroup);
                    }
                    if (clsDuLieu.NguoiDungDangNhap != null)
                        PhanQuyen.FindAndNew(null, clsDuLieu.NguoiDungDangNhap.Nhom, chucnangPage);
                }

                // Nạp thông tin lên giao diện
                lblNguoiDung.ImageOptions.Image = IMC.Images[1];
                lblNguoiDung.Caption = string.Format("Xin chào, {0}",
                                                    !string.IsNullOrEmpty(clsDuLieu.NguoiDungDangNhap.HoVaTen) ? 
                                                    clsDuLieu.NguoiDungDangNhap.HoVaTen.ToUpper() :
                                                    clsDuLieu.NguoiDungDangNhap.TaiKhoan.ToUpper());
                itemNhomNguoiDung.Caption = string.Format("Nhóm: {0}", clsDuLieu.NguoiDungDangNhap.Nhom.TenNhom);
                itemNguoiDung.Caption = string.Format("Người dùng: {0}", clsDuLieu.NguoiDungDangNhap.TaiKhoan);
                NapNienKhoa();
                #endregion
            }
            else
            {
                // Thoát ứng dụng
                Application.ExitThread();
            }
        }
        private void btnGiaiPhongBoNho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gabageMem = GC.GetTotalMemory(false);
            GC.RemoveMemoryPressure(gabageMem);
            GC.Collect();
            Refresh();
            var msg = string.Empty;

            var gabageMem2 = GC.GetTotalMemory(false);
            var mem = gabageMem - gabageMem2;
            if (mem.ToString().Length <= 3) // Byte
                msg = string.Format("Đã giải phóng {0} Bytes bộ nhớ", mem);
            else if (mem.ToString().Length <= 6) // KB
                msg = string.Format("Đã giải phóng {0} KB bộ nhớ", mem / 1024);
            else if (mem.ToString().Length <= 9) // MB
                msg = string.Format("Đã giải phóng {0} MB bộ nhớ", mem / (1024 * 1024));
            else
                msg = string.Format("Đã giải phóng {0} GB bộ nhớ", gabageMem / (1024 * 1024 * 1024));

            MsgBox.ShowSuccessfulDialog(msg);
        }
        private void btnDongTatCaTab_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
                f.Close();
        }
        private void btnKhoaUngDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangNhap();
        }
        private void btnKetNoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            MsgBox.OpenDialog<FrmKetNoiDB>(true);
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.MSSQL)
                ConnectionHelper.RestoreSQL();
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.ACCESS)
                ConnectionHelper.RestoreAccess();
        }
        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.MSSQL)
                ConnectionHelper.BackupSQL();
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.ACCESS)
                ConnectionHelper.BackupAccess();
        }

        private void btnNienKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmNienKhoa>();
        }

        private void btnThamSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            MsgBox.OpenDialog<FrmThamSo>();
        }

        private void btnHanhChinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmHanhChinh>();
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmPhanQuyen>();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            MsgBox.OpenDialog<FrmNguoiDung>(clsDuLieu.NguoiDungDangNhap);
        }

        private void btnDonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmDonVi>();
        }

        private void btnNhapTuExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            MsgBox.OpenDialog<FrmNhapTuExcel>();
        }

        private void btnNhanSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmNhanSu>();
        }

        private void btnKhenThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmKhenThuong>();
        }

        private void btnKyLuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmKyLuat>();
        }

        private void btnQuanLyVanBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsHeThong.ChucNangDangChon = e.Item.Tag as ChucNang;
            OpenForm<FrmVanBan>();
        }
    }
}
