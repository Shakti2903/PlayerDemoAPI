using System.Net.Mail;
using System.Net;

namespace PlayerServices
{
    public static class MailClass
    {
        public static bool SendMail(string ToMail, string Subject, string Body)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("shaktisingh.chauhan@bacancy.com");
            mailMessage.To.Add(ToMail);
            mailMessage.Subject = Subject;
            mailMessage.Body = Body;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("shaktisingh.chauhan@bacancy.com", "Shaktiatbacancy@121");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
