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
using QuanLyDoanVien.TienIch;

namespace QuanLyDoanVien.NghiepVu.QLVanBan
{
    public partial class FrmThongKeVanBanTheoLoai : FrmBase
    {
        clsThongKe_VanBan cls;
        public FrmThongKeVanBanTheoLoai()
        {
            InitializeComponent();

            cls = new clsThongKe_VanBan();
            OnNap();
        }
        protected override void OnNap()
        {
            gridControlCustom1.DataSource = cls.ThongKeVanBanTheoLoai();
        }
    }
}