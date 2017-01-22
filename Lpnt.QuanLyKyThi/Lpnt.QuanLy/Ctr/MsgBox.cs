using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace Lpnt.QuanLy.Ctr
{
    public class MsgBox
    {
        public static void OpenDialog<T>() where T : Form
        {
            ShowWaitForm();

            var f = Activator.CreateInstance<T>();
            f.ShowInTaskbar = false;
            f.MinimizeBox = false;
            CloseWaitForm();

            f.ShowDialog();
        }

        public static DialogResult OpenDialog<T>(object arg) where T : Form
        {
            ShowWaitForm();

            var f = Activator.CreateInstance(typeof (T), arg) as T;
            f.ShowInTaskbar = false;
            f.MinimizeBox = false;

            CloseWaitForm();
            f.ShowDialog();

            return f.DialogResult;
        }

        #region Dialog Message

        /// <summary>
        ///     Hiện msg box (yes/no)
        /// </summary>
        /// <param name="text">Nội dung cần thông báo</param>
        /// <returns>DialogResult</returns>
        public static DialogResult ShowYesNoDialog(string text)
        {
            return XtraMessageBox.Show(text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        ///     Hiện msg box thông báo thao tác thành công
        /// </summary>
        /// <param name="message">Lưu/Xóa/Sửa/...</param>
        /// <returns>DialogResult</returns>
        public static DialogResult ShowSuccessfulDialog(string message)
        {
            return XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Hiện msg box thông báo thao tác không thành công
        /// </summary>
        /// <param name="action">Lưu/Xóa/Sửa/...</param>
        /// <returns>DialogResult</returns>
        public static DialogResult ShowUnsuccessfulDialog(string action)
        {
            return XtraMessageBox.Show(action, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Hiện msg box thông báo lỗi
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowErrorDialog(string text)
        {
            if (text.Contains("Cannot delete or update a parent row: a foreign key constraint fails")
                || text.Contains("includes related records")
                || text.Contains("violation of FOREIGN KEY constraint")
                )
                text = "Không thể xóa dữ liệu quan hệ";
            else if (text.Contains("Unable to open database"))
                text = "Không thể kết nối CSDL";
            else if (text.Contains("cannot open or write to the file"))
                text = "Tập tin đang được sử dụng bởi chương trình khác";

            return XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Hiện msg box cảnh báo
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowWarningDialog(string text)
        {
            return XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowYesNoCancelDialog(string text)
        {
            return XtraMessageBox.Show(text, "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ShowYesNoCancelDialog(string caption, string text)
        {
            return XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        #endregion

        #region WaitForm

        public static void ShowWaitForm()
        {
            if (SplashScreenManager.Default != null) return;
            SplashScreenManager.ShowForm(typeof (FrmWait));
        }

        public static void ShowWaitForm<T>()
        {
            if (SplashScreenManager.Default != null) return;
            SplashScreenManager.ShowForm(typeof (T));
        }


        public static void ShowWaitForm(string description)
        {
            if (SplashScreenManager.Default != null)
                if (SplashScreenManager.Default.IsSplashFormVisible)
                {
                    SplashScreenManager.Default.SetWaitFormDescription(description);
                    return;
                }
            SplashScreenManager.ShowForm(typeof (FrmWait));
            if (SplashScreenManager.Default != null) SplashScreenManager.Default.SetWaitFormDescription(description);
        }

        public static void ShowWaitForm(string description, Form parentForm)
        {
            if (SplashScreenManager.Default != null)
                if (SplashScreenManager.Default.IsSplashFormVisible)
                {
                    SplashScreenManager.Default.SetWaitFormDescription(description);
                    return;
                }

            SplashScreenManager.ShowForm(parentForm, typeof (FrmWait));
            if (SplashScreenManager.Default != null) SplashScreenManager.Default.SetWaitFormDescription(description);
        }

        public static void SetWaitFormDescription(string description)
        {
            if (SplashScreenManager.Default != null)
                if (SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.Default.SetWaitFormDescription(description);
        }

        public static void CloseWaitForm()
        {
            if (SplashScreenManager.Default != null)
                if (SplashScreenManager.Default.IsSplashFormVisible)
                {
                    SplashScreenManager.CloseForm();
                }
        }

        #endregion

        #region SplashForm

        public static void ShowSplashForm()
        {
            if (SplashScreenManager.Default != null) return;
            SplashScreenManager.ShowForm(typeof (FrmSplash));
        }

        public static void ShowSplashForm(string description)
        {
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
            {
                SplashScreenManager.Default.SendCommand(null, description);
                return;
            }
            SplashScreenManager.ShowForm(typeof (FrmSplash));
        }

        public static void CloseSplashForm()
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion
    }
}