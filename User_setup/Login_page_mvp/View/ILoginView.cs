using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.View
{
    internal interface ILoginView
    {

        string Login_text { get; init; }
        string Password_text { get; init; }


        void UpdateUI();

    }
}
