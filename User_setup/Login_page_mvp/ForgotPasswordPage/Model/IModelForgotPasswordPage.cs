using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.Model
{
    internal interface IModelForgotPasswordPage
    {
       public int Code { get; set; }

        internal bool isSecEqualFirst(string First, string Second);

        

    }
}
