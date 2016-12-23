using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDoanVien.TienIch
{
    public class WriteLog
    {
        public static void WriteLogText(string description)
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "/error.txt", true, System.Text.Encoding.Unicode))
            {
                string str = string.Format("{0:dd/MM/yyyy hh:mm:ss tt}\t:\t{1}", DateTime.Now, description);
                sw.WriteLine(str);
            }
        }
    }
}
