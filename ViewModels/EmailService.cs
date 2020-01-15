using System;
using System.Net.Mail;
using System.Windows;

namespace it_company.ViewModels
{
    internal class EmailService
    {
        public void SendPasswordOnEmail()
        {
            try
            {
                var mail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("kolanio757@gmail.com");
                mail.To.Add("my_last_@outlook.com");
                mail.Subject = "New Password";
                mail.Body = "Password";

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("kolanio757@gmail.com", "759G5Fult8s");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
