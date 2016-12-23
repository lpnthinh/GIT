using System.Configuration;

namespace QuanLyDoanVien.TienIch
{
    public class AppConfig
    {
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }

        public static void SetValue(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}