using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyDoanVien.DuLieu;

namespace QuanLyDoanVien.TienIch
{
    public partial class RptBase : DevExpress.XtraReports.UI.XtraReport
    {
        ChucNang chucnangdangchon;
        private string _tenBaoCao;
        public RptBase()
        {
            InitializeComponent();
            chucnangdangchon = clsHeThong.ChucNangDangChon;
        }
        public string TenBaoCao
        {
            get
            {
                return _tenBaoCao;
            }

            set
            {
                _tenBaoCao = value;
            }
        }
    }
}
