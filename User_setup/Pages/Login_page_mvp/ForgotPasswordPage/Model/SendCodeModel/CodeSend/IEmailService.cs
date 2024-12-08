using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model.SendCodeModel.CodeSend
{
    internal interface IEmailService
    {
        void SendEmail(string recipientEmail, string subject, string body);
    }
}
