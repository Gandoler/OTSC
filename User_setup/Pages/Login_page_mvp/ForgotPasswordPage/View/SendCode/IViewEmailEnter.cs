using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.SendCode
{
    internal interface IViewEmailEnter
    {

        public void MakeVisibleEmailerror();
        public void MakeNotVisibleEmailerror();
        public void MakeSendButtonEnable();
        public void MakeSendButtonDisable();
        public void MakeCloseButtonRed();
        public void MakeCloseButtonBlack();

        public bool CheckCorrectInputEmail();

        public bool ImageErrorrVisible { set; }
        event Action EnterEmailTextBox;
        event EventHandler<string> LeaveEmailBoxAndCheckCorrect;
        event Action SendCodeButtonClick;
        event Action ExitForgotPageButtonClick;
        event Action EnterExitButton;
        event Action LeaveExitButton;
    }
}
