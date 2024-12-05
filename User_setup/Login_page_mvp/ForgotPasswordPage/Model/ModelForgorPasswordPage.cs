using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.ForgotPasswordPage.Model;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.Model
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
