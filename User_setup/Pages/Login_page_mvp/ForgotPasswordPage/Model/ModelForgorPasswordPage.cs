﻿namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model
{
    internal class ModelForgorPasswordPage : IModelForgotPasswordPage
    {
        private int _code;

        public int Code { get => _code; set => _code = value; }

        bool IModelForgotPasswordPage.CheckCode(short Code)
        {
            throw new NotImplementedException();
        }

        void IModelForgotPasswordPage.MakeNewPasswordQuery(string First, string Second)
        {
            throw new NotImplementedException();
        }

        bool IModelForgotPasswordPage.SendCode(string email)
        {
            throw new NotImplementedException();
        }
    }
}
