using QuanLyDoanVien.DuLieu;
using QuanLyDoanVien.TienIch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien
{
    public class clsHeThong
    {
        public static ChucNang ChucNangDangChon
        {
            get;
            set;
        }
        public static NienKhoa NienKhoaSuDung
        {
            get;
            set;
        }
        public static bool IsOffice2003()
        {
            object tmp;
            Param.GetValue("Phiên bản Microsoft Office", out tmp);

            return tmp.ToString().Equals("Phiên bản 2003") ? true : false;
        }
        public static string TenTepVanBan(int kieu)
        {
            string ten = string.Empty;
            string tiento = kieu == Constant.KIEU_VAN_BAN_DI ? "vbdi" : "vbden";
            int so = 1;
            ten = string.Format("{0}_{1:d4}", tiento, so);

            while (VanBan.FindObject<VanBan>("TepDinhKem", ten) != null)
            {
                ten = string.Format("{0}_{1:d4}", tiento, so++);
            }

            return ten;
        }
    }
}
