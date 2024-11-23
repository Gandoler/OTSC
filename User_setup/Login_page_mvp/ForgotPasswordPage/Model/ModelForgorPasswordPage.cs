using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.Model
{
    internal class ModelForgorPasswordPage : IModelForgotPasswordPage
    {
        private int _code;
        public int Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (value < 100000 || value>= 1000000)
                {
                    throw new ArgumentException("code format: xxxxxx");
                }
                _code = value;
            }
        }

        public bool isSecEqualFirst(string First, string Second)
        {
            if (First.CompareTo(Second) == 0) return true;
            else return false;
        }
    }
}
