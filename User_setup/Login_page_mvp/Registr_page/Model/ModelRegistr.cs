using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace User_Interface.Login_page_mvp.Registr_page.Model
{
    internal class ModelRegistr: ImodelRegistr
    {
        private long _login;
        private string? _password;
        private string? _email;
        public long Login
        {

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    _login = value;
                }
            }
        }


        public string Password
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    ArgumentNullException argumentNullException = new(nameof(_login));
                    throw argumentNullException;
                }
                else
                {
                    _password = value;
                }


            }
        }

        public string Email
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    ArgumentNullException argumentNullException = new(nameof(_email));
                    throw argumentNullException;
                }
                else
                {
                    _email = value;
                }


            }
        }
    }
}
