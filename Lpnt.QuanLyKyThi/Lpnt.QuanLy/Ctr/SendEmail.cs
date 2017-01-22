using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lpnt.QuanLy.Ctr
{
    /*      
    *      Server Name	    SMTP Address	        Port	SSL
    *      Yahoo!	        smtp.mail.yahoo.com	    587	    Yes
    *      GMail	        smtp.gmail.com	        587	    Yes
    *      Hotmail	        smtp.live.com	        587	    Yes
    */
    public class SendEmail
    {
        public static bool Send(string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage(Constant.EMAIL_FROM, Constant.EMAIL_TO, subject, body)
                {
                    IsBodyHtml = false
                    //Can set to false, if you are sending pure text.
                };

                //mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                //mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                SmtpClient client = new SmtpClient(Constant.HOST, Constant.PORT)
                {
                    EnableSsl = Constant.ENABLE_SSL,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(Constant.EMAIL_FROM, Constant.EMAIL_PASSWORD),
                    Timeout = 10000
                };

                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog("Gửi thất bại!\n\n" + ex.Message);
                return false;
            }
        }
    }
}
