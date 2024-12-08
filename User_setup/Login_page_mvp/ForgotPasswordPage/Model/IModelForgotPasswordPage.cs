using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.Model
{
    internal interface IModelForgotPasswordPage
    {
        internal bool SendCode(string email);
        internal void MakeNewPasswordQuery(string First, string Second);
        internal bool CheckCode(short Code);



    }
}
