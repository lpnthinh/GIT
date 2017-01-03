using DevExpress.Xpo;
using QuanLyDoanVien.DuLieu;
using QuanLyDoanVien.TienIch;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien.NghiepVu.QLVanBan
{
    public class clsThongKe_VanBan
    {
        public DataTable ThongKeVanBanTheoLoai()
        {
            XPCollection<LoaiVanBan> xpcLoaiVanBans = new XPCollection<LoaiVanBan>(XpoDefault.Session);

            var query = from lvb in xpcLoaiVanBans
                           select new
                           {
                               colTenLoaiVanBan = lvb.Ten,
                               colTongSoVanBanTheoLoai = lvb.VanBans.Where(f => f.LoaiVanBan.Id == lvb.Id).Count(),
                               colSoVanBanDiTheoLoai = lvb.VanBans.Where(f => f.LoaiVanBan.Id == lvb.Id && f.Kieu == (int)KieuVanBan.Di).Count(),
                               colSoVanBanDenTheoLoai = lvb.VanBans.Where(f => f.LoaiVanBan.Id == lvb.Id && f.Kieu == (int)KieuVanBan.Den).Count(),
                           };

            return LinqToDatable.LINQResultToDataTable(query.ToList());
        }

        public DataTable ThongKeSoLuong()
        {
            XPCollection<VanBan> VanBans = new XPCollection<VanBan>(XpoDefault.Session);
            DataTable dt = new DataTable();
            dt.Columns.Add("Số văn bản đi", typeof(int));
            dt.Columns.Add("Số văn bản đến", typeof(int));
            dt.Columns.Add("Tổng số", typeof(int));
            DataRow r = dt.NewRow();
            r["Số văn bản đi"] = VanBans.Where(c => c.Kieu == (int)KieuVanBan.Di).Count();
            r["Số văn bản đến"] = VanBans.Where(c => c.Kieu == (int)KieuVanBan.Den).Count();
            r["Tổng số"] = VanBans.Count();
            dt.Rows.Add(r);

            return dt;
        }

        public DataTable ThongKeVanBanTheoNam()
        {
            DataTable dt = new DataTable();

            return dt;
        }
    }
}
