using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.View
{
    internal interface IViewForgotPasswordPage
    {
        public string EmailField { get; }
        public string CodeField { get; }

        public string PasswordField { get; }
        public string PasswordSecondField { get; }



        public void MakeCodeFieldEnable();
        public void MakeCodeFieldDisable();
        public void RemakeWindow();

        public void ClearPasswords();

        public void DisableMissmatchLabel();


        //FOR ALL
        //
        // Exit from application
        event EventHandler Exit_Aplicatiom;
        ////////////////////////////////////


        //FOR CODE ENTER
        //
        // User had been Entered his email (Field for code must be enable)
        event EventHandler User_Enter_EMAIL;
        // User Change his Email
        event Action ChangeEmail;
        // User input code and press 
        event Action ButtonConfirmCode;


        //FOR PASSWORD NEW ENTER
        //
        // Save new password
        event EventHandler Save_New_Password;


    
        




    }
}
