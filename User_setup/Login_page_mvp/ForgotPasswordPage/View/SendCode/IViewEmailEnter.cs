using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.View.SendCode
{
    internal interface IViewEmailEnter
    {

        public void MakeVisibleEmailerror();
        public void MakeNotVisibleEmailerror();
        public void MakeSendButtonEnable();
        public void MakeSendButtonDisable();

        public bool ImageErrorrVisible { set; }
        event Action EnterEmailTextBox;
        event EventHandler<string> LeaveEmailBoxAndCheckCorrect;
        event Action SendCodeButtonClick;
        event Action ExitForgotPageButtonClick;
        event EventHandler<Color> EnterExitButton;
        event EventHandler<Color> LeaveExitButton;
    }
}
