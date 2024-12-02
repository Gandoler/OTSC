using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.View
{
    internal interface IViewEmailEnter
    {
        public string EmailField { get; }
        
        public void NextPage();
        event EventHandler LeaveEmailBoxCheckCorrect;
        event Action EnterSendCodeButton;
        event Action LeaveForgotpage;
    }
}
