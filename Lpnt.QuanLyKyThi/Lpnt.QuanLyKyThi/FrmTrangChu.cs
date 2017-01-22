using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Lpnt.QuanLy;
using Lpnt.QuanLy.Ctr;
using Lpnt.QuanLy.Frm;
using Lpnt.QuanLyKyThi.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lpnt.QuanLyKyThi
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
        public void NapNamHoc()
        {
            itemNamHoc.Caption = "Niên khóa";

            XpoDefault.Session.Disconnect();
            XpoDefault.Session.Connect();

            var namhoc = NamHoc.FindObject<NamHoc>("SuDung", true);
            if (namhoc != null)
            {
                itemNamHoc.Caption = string.Format("Năm học: {0}", namhoc.Ten);
                clsHeThong.NamHocSuDung = namhoc;
            }
        }
        private void OpenForm<T>()
        {
            PhanQuyen p = PhanQuyen.Find(clsDuLieu.NguoiDungDangNhap.NhomNguoiDung, clsQuanLy.ChucNangDangChon);
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
            PhanQuyen p = PhanQuyen.Find(clsDuLieu.NguoiDungDangNhap.NhomNguoiDung, clsQuanLy.ChucNangDangChon);
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

            itemNhomNguoiDung.Caption = "[Nhóm người dùng]";
            itemNguoiDung.Caption = "[Người dùng]";
            itemNhomNguoiDung.ImageOptions.Image = itemNhomNguoiDung.ImageOptions.LargeImage = IMC.Images[0];
            itemNguoiDung.ImageOptions.Image = itemNguoiDung.ImageOptions.LargeImage = IMC.Images[1];

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
                                var quyenItem = PhanQuyen.FindAndNew(null, clsDuLieu.NguoiDungDangNhap.NhomNguoiDung, chucnangItem);
                                itemlink.Item.Enabled = quyenItem.TruyCap;
                            }

                            // CHEAT NGƯỜI DÙNG HỆ THỐNG
                            if (clsDuLieu.NguoiDungDangNhap == null)
                                itemlink.Item.Enabled = true;
                        }
                        if (clsDuLieu.NguoiDungDangNhap != null)
                            PhanQuyen.FindAndNew(null, clsDuLieu.NguoiDungDangNhap.NhomNguoiDung, chucnangGroup);
                    }
                    if (clsDuLieu.NguoiDungDangNhap != null)
                        PhanQuyen.FindAndNew(null, clsDuLieu.NguoiDungDangNhap.NhomNguoiDung, chucnangPage);
                }

                // Nạp thông tin lên giao diện
                itemNhomNguoiDung.Caption = string.Format("Nhóm: [{0}]", clsDuLieu.NguoiDungDangNhap.NhomNguoiDung.TenNhom);
                itemNguoiDung.Caption = string.Format("Đăng nhập: [{0}]", clsDuLieu.NguoiDungDangNhap.TenDangNhap);

                itemNhomNguoiDung.ImageOptions.Image = itemNhomNguoiDung.ImageOptions.LargeImage = IMC.Images[2];
                itemNguoiDung.ImageOptions.Image = itemNguoiDung.ImageOptions.LargeImage = IMC.Images[3];
                itemNguoiDung.Hint = string.Format("Xin chào, {0}",
                                                    !string.IsNullOrEmpty(clsDuLieu.NguoiDungDangNhap.HoVaTen) ?
                                                    clsDuLieu.NguoiDungDangNhap.HoVaTen.ToUpper() :
                                                    clsDuLieu.NguoiDungDangNhap.TenDangNhap.ToUpper());

                NapNamHoc();
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
            clsQuanLy.ChucNangDangChon = e.Item.Tag as ChucNang;
            MsgBox.OpenDialog<FrmKetNoiDB>(true);
        }
        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsQuanLy.ChucNangDangChon = e.Item.Tag as ChucNang;
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.MSSQL)
                ConnectionHelper.BackupSQL();
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.ACCESS)
                ConnectionHelper.BackupAccess();
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsQuanLy.ChucNangDangChon = e.Item.Tag as ChucNang;
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.MSSQL)
                ConnectionHelper.RestoreSQL();
            if (Convert.ToInt32(AppConfig.GetValue("ServerType")) == (int)ServerType.ACCESS)
                ConnectionHelper.RestoreAccess();
        }
    }
}
