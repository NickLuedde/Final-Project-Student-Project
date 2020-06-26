using System.Net;
using System.Net.Mail;

namespace GAG_101
{
    public static class MessageSender
    {
        private const string FromAddress = "gotaGuymatchmaker@gmail.com";
        private const string Password = "vjxnwqyewovsknjz";
        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;

        public static void SendEmail(string toAddress, string subject, string messageBody)
        {
            using (var client = new SmtpClient(SmtpHost, SmtpPort))

            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(FromAddress, Password);
                client.EnableSsl = true;

                using (var msg = new MailMessage()) ;
                {
                    var msg = new MailMessage();
                    msg.From = new MailAddress(FromAddress);
                    msg.To.Add(new MailAddress(toAddress));
                    msg.Body = messageBody;
                    msg.IsBodyHtml = true;

                    client.Send(msg);
                }
            }
        }
    }
}