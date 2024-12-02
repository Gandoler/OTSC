using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.View
{
    internal interface IViewEmailEnter
    {
        
        public void NextPage();

        public bool ImageErrorrVisible { set; }
        event EventHandler<string> LeaveEmailBoxAndCheckCorrect;
        event Action SendCodeButtonClick;
        event EventHandler ExitForgotPageButtonClick;
        event EventHandler<Color> EnterExitButton;
        event EventHandler<Color> LeaveExitButton;
    }
}
