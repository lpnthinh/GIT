using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyDoanVien.HeThong
{
    public enum ServerType
    {
        MSSQL = 0,
        ACCESS = 1
    }
    public partial class FrmKetNoiDB : DevExpress.XtraEditors.XtraForm
    {
        public FrmKetNoiDB()
        {
            InitializeComponent();
        }
    }
}