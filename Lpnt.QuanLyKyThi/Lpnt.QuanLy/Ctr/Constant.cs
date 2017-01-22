using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lpnt.QuanLy.Ctr
{
    public class Constant
    {
        public const string DATABASE_NAME_ACCESS = "QuanLyKyThi.mdb";
        public const string DATABASE_NAME_MSSQL = "QuanLyKyThi";

        public const string SECURITY_KEY = "lpnt.it";

        #region Email
        public const string EMAIL_FROM = "quanlynhansu.thpt@gmail.com";
        public const string EMAIL_PASSWORD = "quanlynhansuthpt";
        public const string EMAIL_TO = "lpnt.it@gmail.com";

        public const string HOST = "smtp.gmail.com";
        public const int PORT = 587;
        public const bool ENABLE_SSL = true;
        #endregion
    }
}
