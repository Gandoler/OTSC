using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.SendMailWithcode.CodeSend
{
    internal interface IEmailService
    {
        void SendEmail(string recipientEmail, string subject, string body);
    }
}
