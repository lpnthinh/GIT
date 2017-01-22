using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Lpnt.QuanLy.Ctr
{
    public partial class FrmSplash : SplashScreen
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            lbTieuDe.Text = arg as string;
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}