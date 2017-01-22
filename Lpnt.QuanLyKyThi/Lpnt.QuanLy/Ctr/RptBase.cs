using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lpnt.QuanLy.Ctr
{
    public partial class RptBase : DevExpress.XtraReports.UI.XtraReport
    {
        private string _TenBaoCao;
        public RptBase()
        {
            InitializeComponent();
        }

        public string TenBaoCao
        {
            get
            {
                return _TenBaoCao;
            }

            set
            {
                _TenBaoCao = value;
            }
        }
    }
}
