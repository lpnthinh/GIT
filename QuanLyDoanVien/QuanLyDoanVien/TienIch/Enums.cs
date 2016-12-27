using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien.TienIch
{
    public enum GioiTinh
    {
        [Description("Nam")]
        Nam = 0,
        [Description("Nữ")]
        Nu = 1,
    }
    public enum TrangThaiDoan
    {
        [Description("Thanh niên")]
        ThanhNien = 0,
        [Description("Đoàn viên")]
        DoanVien = 1,
        [Description("Trưởng thành")]
        TruongThanh = 2,
        [Description("Xóa tên")]
        XoaTen = 3
    }
    public enum DangVien
    {
        [Description("Không")]
        Khong = 0,
        [Description("Dự bị")]
        DuBi = 1,
        [Description("Chính thức")]
        ChinhThuc = 2
    }

    public enum CapDonVi
    {
        [Description("Trung ương")]
        TW = 0,
        [Description("Tinh")]
        Tinh = 1,
        [Description("Huyện")]
        Huyen = 2,
        [Description("Đơn vị")]
        DonVi = 3,
        [Description("Chi đoàn")]
        ChiDoan = 4
    }

    public enum PhiaQuanHe
    {
        [Description("Bản thân")]
        BanThan = 0,
        [Description("Vợ (chồng)")]
        VoHoacChong = 1
    }
    public enum MoiQuanHe
    {
        [Description("Ông nội")]
        OngNoi = 0,
        [Description("Bà nội")]
        BaNoi = 1,
        [Description("Ông ngoại")]
        OngNgoai = 2,
        [Description("Bà ngoại")]
        BaNgoai = 3,
        [Description("Cha đẻ")]
        ChaDe = 4,
        [Description("Mẹ đẻ")]
        MeDe = 5,
        [Description("Em ruột")]
        EmRuot = 6
    }
}
