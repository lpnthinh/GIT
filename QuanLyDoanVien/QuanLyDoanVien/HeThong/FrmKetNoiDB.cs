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
using System.IO;
using QuanLyDoanVien.TienIch;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using DevExpress.Xpo;

namespace QuanLyDoanVien.HeThong
{
    public enum ServerType
    {
        MSSQL = 0,
        ACCESS = 1
    }
    public partial class FrmKetNoiDB : DevExpress.XtraEditors.XtraForm
    {
        public bool Connected { get; private set; }
        private readonly bool _needRestart;
        public FrmKetNoiDB(bool needRestart)
        {
            InitializeComponent();

            _needRestart = needRestart;

            string datapath = Application.StartupPath + "\\Data";
            if (!Directory.Exists(datapath)) Directory.CreateDirectory(datapath);

            var serverType = Convert.ToInt32(AppConfig.GetValue("ServerType"));
            var server = AppConfig.GetValue("Server");
            var user = AppConfig.GetValue("User");
            var pass = AppConfig.GetValue("Password");
            var database = AppConfig.GetValue("Database");
            var cmode = Convert.ToInt32(AppConfig.GetValue("ConnectionMode"));

            cboType.SelectedIndex = serverType;
            txtSeverName.Text = server;
            txtLoginName.Text = user;
            txtPassword.Text = pass;
            cboDatabase.Text = database;
            rGrpConnectUsing.EditValue = cmode;
        }
        public bool ConnectDatabase()
        {
            if (cboType.SelectedIndex == (int)ServerType.ACCESS)
            {
                if (!cboDatabase.Text.Contains(@"\"))
                {
                    cboDatabase.Text = string.Format(@"{0}\Data\{1}", Application.StartupPath, cboDatabase.Text);
                }
            }

            string sConnectionString = ConnectionHelper.GetConnectionString(cboType.SelectedIndex
                , rGrpConnectUsing.SelectedIndex
                , txtSeverName.Text
                , txtLoginName.Text
                , txtPassword.Text
                , cboDatabase.Text);

            try
            {
                var s = new Session() { ConnectionString = sConnectionString };
                s.Connect();

                s.Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }
        private void cboDatabase_QueryPopUp(object sender, CancelEventArgs e)
        {
            MsgBox.ShowWaitForm();
            cboDatabase.Properties.Items.Clear();
            if (cboType.SelectedIndex != (int)ServerType.MSSQL)
            {
                e.Cancel = true;
                return;
            }

            string connectionString = String.Format("data source={0};integrated security={1};user={2};password={3}"
                , txtSeverName.Text, rGrpConnectUsing.SelectedIndex == 0 ? "SSPI" : "false", txtLoginName.Text, txtPassword.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MsgBox.CloseWaitForm();
                    MsgBox.ShowErrorDialog("Không kết nối được cơ sở dữ liệu");
                    return;
                }
                using (SqlCommand command = new SqlCommand("select name from master..sysdatabases", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            if (name != "master" && name != "model" && name != "tempdb" && name != "msdb" && name != "pubs")
                                cboDatabase.Properties.Items.Add(name);
                        }
                    }
                }
                connection.Close();
            }
            if (cboDatabase.Properties.Items.Count > 0)
                cboDatabase.SelectedIndex = 0;

            MsgBox.CloseWaitForm();
        }
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rGrpConnectUsing.Enabled = true;
            txtLoginName.Enabled = txtPassword.Enabled = rGrpConnectUsing.SelectedIndex == 1 ? true : false;
            txtSeverName.Enabled = !(cboType.SelectedIndex == (int)ServerType.ACCESS);
            switch (cboType.SelectedIndex)
            {
                case (int)ServerType.MSSQL:
                    cboDatabase.Properties.Buttons[0].Visible = true;
                    cboDatabase.Properties.Buttons[1].Visible = false;

                    txtSeverName.Text = @"(LOCAL)\SQLEXPRESS";
                    txtLoginName.Text = "sa";
                    txtPassword.Text = string.Empty;

                    rGrpConnectUsing.Properties.Items[0].Description = "Dùng quyền Windows";
                    rGrpConnectUsing.Properties.Items[1].Description = "Dùng quyền SQL Server";
                    rGrpConnectUsing.Enabled = true;
                    cboDatabase.Text = string.Empty;
                    break;

                case (int)ServerType.ACCESS:
                    cboDatabase.Properties.Buttons[1].Visible = true;
                    cboDatabase.Properties.Buttons[0].Visible = false;
                    rGrpConnectUsing.Enabled = false;
                    rGrpConnectUsing.EditValue = 0;
                    break;
            }
        }
        private void cboDatabase_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var openDlg = new OpenFileDialog() { InitialDirectory = Application.StartupPath };

                if (openDlg.ShowDialog() == DialogResult.OK)
                    cboDatabase.Text = openDlg.FileName;
            }
        }
        private void rGrpConnectUsing_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLoginName.Enabled = txtPassword.Enabled = rGrpConnectUsing.SelectedIndex == 1 ? true : false;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            MsgBox.ShowWaitForm();
            Connected = ConnectDatabase();
            MsgBox.CloseWaitForm();

            if (!Connected) return;

            if (_needRestart)
            {
                var res =
                    MsgBox.ShowYesNoDialog(
                        "Kết nối thành công, bạn có muốn lưu lại cấu hình và khởi động lại chương trình?");
                if (res == DialogResult.Yes)
                {
                    AppConfig.SetValue("ServerType", cboType.SelectedIndex.ToString());
                    AppConfig.SetValue("Server", txtSeverName.Text);
                    AppConfig.SetValue("User", txtLoginName.Text);
                    AppConfig.SetValue("Password", txtPassword.Text);
                    AppConfig.SetValue("Database", cboDatabase.Text);
                    AppConfig.SetValue("ConnectionMode", rGrpConnectUsing.EditValue.ToString());

                    var s = Application.ExecutablePath;
                    Application.ExitThread();

                    Process.Start(s, "reset");
                }
            }

            DialogResult = Connected ? DialogResult.OK : DialogResult.Cancel;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}