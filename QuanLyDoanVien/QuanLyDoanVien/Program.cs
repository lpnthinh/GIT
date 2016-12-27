using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;
using QuanLyDoanVien.TienIch;
using System.IO;
using System.Text;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraEditors.Controls;
using QuanLyDoanVien.HeThong;

namespace QuanLyDoanVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Skin = AppConfig.GetValue("Skin");
            UserLookAndFeel.Default.SetSkinStyle(Skin);

            GridLocalizer.Active = new VietNamGridLocalizer();
            Localizer.Active = new VietNamEditorsLocalizer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            bool isConnected = ConnectionHelper.Connect();
            while (!isConnected)
            {
                if (MsgBox.ShowYesNoDialog("Không thể kết nối cơ sở dữ liệu!\nBạn có muốn thiết lập lại kết nối?") == DialogResult.Yes)
                {
                    var f = new FrmKetNoiDB(true);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        isConnected = ConnectionHelper.Connect();
                        return;
                    }
                }
                else
                    return;
            }

            Application.Run(new FrmTrangChu());
        }
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs ex)
        {
            if (ex.Exception.Message.Contains("error has occurred when receiving results from the server")
                || ex.Exception.Message.Contains("Could not open a connection"))
                MsgBox.ShowErrorDialog("Không kết nối được cơ sở dữ liệu");
            else
            {
                string err = string.Format("{0}\n{1}\n{2}", ex.Exception.Message, ex.Exception.TargetSite.Name, ex.Exception.StackTrace);
                MsgBox.ShowErrorDialog("Lỗi chưa xử lí\n\n" + err);
            }

            File.AppendAllText(Application.StartupPath + "/log.txt"
                , ex.Exception.ToString(), Encoding.Unicode);
        }
    }
}
