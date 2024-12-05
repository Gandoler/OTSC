using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.Model.SendCodeModel.CodeSend
{
    internal class EmailService : IEmailService
    {
        private readonly string _senderEmail;
        private readonly string _senderPassword;
        private readonly string _smtpHost;
        private readonly int _smtpPort;


        public EmailService(string senderEmail, string senderPassword, string smtpHost, int smtpPort)
        {
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
            _smtpHost = smtpHost;
            _smtpPort = smtpPort;
        }

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

            using (var smtpClient = new SmtpClient(_smtpHost, _smtpPort)
            {
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true
            })
            {
                smtpClient.Send(mail);
            }
        }
    }
}
}
