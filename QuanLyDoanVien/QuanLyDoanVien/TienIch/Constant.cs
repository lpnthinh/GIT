using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien.TienIch
{
    public class Constant
    {
        public const string DATABASE_NAME_ACCESS = "QuanLyDoanVien.mdb";
        public const string DATABASE_NAME_MSSQL = "QuanLyDoanVien";

        public const string SECURITY_KEY = "lpnt.it";

        #region Email
        public const string EMAIL_FROM = "quanlynhansu.thpt@gmail.com";
        public const string EMAIL_PASSWORD = "quanlynhansuthpt";
        public const string EMAIL_TO = "lpnt.it@gmail.com";

        public const string HOST = "smtp.gmail.com";
        public const int PORT = 587;
        public const bool ENABLE_SSL = true;
        #endregion

        #region Văn bản
        public const int KIEU_VAN_BAN_DI = 0;
        public const int KIEU_VAN_BAN_DEN = 1;
        #endregion
    }
}
