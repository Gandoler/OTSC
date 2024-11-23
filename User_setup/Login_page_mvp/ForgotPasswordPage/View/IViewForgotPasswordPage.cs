﻿using System;
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

        





        // dlia momenta kogda kod uzje vveden 
        // doljno dernut na polia zameni parolia
        event EventHandler SaveNewPasswordButtonPress;
        // dlia vihoda
        event EventHandler ExitButtonPress;
        //moment kogda vvel email doljno razblokirovat pole vvoda koda
        event EventHandler SendCodeButtonPress;
        //esli tip reshit pomeniat pochtu
        event Action EnterInEmailField;




    }
}
