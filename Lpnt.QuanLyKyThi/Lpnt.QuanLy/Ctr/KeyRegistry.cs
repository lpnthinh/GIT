using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lpnt.QuanLy.Ctr
{
    public class KeyRegistry : IDisposable
    {
        #region Khóa Registry
        private bool showError = false;
        public bool ShowError
        {
            get { return showError; }
            set { showError = value; }
        }
        private string subKey = string.Format(@"SOFTWARE\{0}", Application.ProductName.ToUpper());
        public string SubKey
        {
            get { return subKey; }
            set { subKey = value; }
        }
        private RegistryKey baseRegistryKey = Registry.CurrentUser;
        public RegistryKey BaseRegistryKey
        {
            get { return baseRegistryKey; }
            set { baseRegistryKey = value; }
        }
        public void Dispose()
        {
            if (baseRegistryKey != null)
            {
                baseRegistryKey.Dispose();
                baseRegistryKey = null;
            }
        }
        public string Read(string KeyName)
        {
            RegistryKey rk = baseRegistryKey;
            RegistryKey sk1 = rk.OpenSubKey(subKey);
            if (sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return (string)sk1.GetValue(KeyName);
                }
                catch (Exception e)
                {
                    ShowErrorMessage(e, "Reading registry " + KeyName);
                    return null;
                }
            }
        }
        public bool Write(string KeyName, object Value)
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                sk1.SetValue(KeyName, Value);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Writing registry " + KeyName);
                return false;
            }
        }
        public bool DeleteKey(string KeyName)
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }
        public bool DeleteSubKeyTree()
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }
        public int SubKeyCount()
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving subkeys of " + subKey);
                return 0;
            }
        }
        public int ValueCount()
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                if (sk1 != null)
                    return sk1.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving keys of " + subKey);
                return 0;
            }
        }
        private void ShowErrorMessage(Exception e, string Title)
        {
            if (showError == true)
                XtraMessageBox.Show(e.Message,
                                Title
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
        }
        #endregion

        #region Tùy Chọn Khởi Động Cùng Windows Cho Ứng Dụng
        /// <summary>
        /// Cơ chế để các ứng dụng được windows gọi start tự động khi mở máy đó là nó sẽ tìm các ứng dụng có đăng ký Startup trong thư mục Run của Registry
        /// Và khởi động lần lượt các ứng dụng. Vậy để thực hiện việc đăng ký này chúng ta làm như sau.
        /// </summary>
        /// <param name="isChecked"></param>
        public static void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (isChecked)
            {
                registryKey.SetValue(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                if (CheckStartup())
                    registryKey.DeleteValue(Application.ProductName);
            }
        }

        /// <summary>
        /// Sau khi đăng ký chúng ta sẽ đọc xem việc đăng ký này có thành công hay không bằng đoạn code sau
        /// </summary>
        /// <returns></returns>
        public static bool CheckStartup()
        {
            bool result = false;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            var rg = registryKey.GetValue(Application.ProductName);
            if (rg != null)
            {
                result = true;
            }

            return result;
        }
        #endregion
    }
}
