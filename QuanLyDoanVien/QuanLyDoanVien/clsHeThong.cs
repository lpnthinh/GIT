using QuanLyDoanVien.DuLieu;
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
    }
}
