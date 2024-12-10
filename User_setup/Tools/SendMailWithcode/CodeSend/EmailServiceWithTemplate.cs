using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OTSC_ui.Tools.AppSettingJsonPhars.Temaplates;

namespace OTSC_ui.Tools.SendMailWithcode.CodeSend
{
    internal class EmailServiceWithTemplate(EmailSettings emailSettings ) : IEmailService
    {
        private readonly string _senderEmail = emailSettings.SenderEmail;
        private readonly string _senderPassword = emailSettings.SenderPassword;
        private readonly string _smtpHost = emailSettings.SmtpServer;
        private readonly int _smtpPort = emailSettings.SmtpPort;


        public void SendEmail(string recipientEmail, string subject, string body)
        {
            var mail = new MailMessage
            {
                From = new MailAddress(_senderEmail, "OTSC"),
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };

            mail.To.Add(recipientEmail);

            using var smtpClient = new SmtpClient(_smtpHost, _smtpPort)
            {
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true
            };
            smtpClient.SendMailAsync(mail);
        }
    }
}
