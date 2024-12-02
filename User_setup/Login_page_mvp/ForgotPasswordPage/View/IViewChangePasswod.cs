using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.View
{
    internal interface IViewChangePasswod
    {
       


        public void EnablepasswordSField();

        
        //fields
        event EventHandler<string> LeaveCodeField;
        event Action EnterInPassswordsFields;

        // save new password button
        event EventHandler<(string,string)> Save_New_Password_buttonClick;

        //exit button
        event Action ExitForgotpageButtonClick;
        event EventHandler ExitButtonEntered;
        event EventHandler ExitButtonLeavd;

        //Back button
        event Action GoBackButtonCLick;

    }
}
