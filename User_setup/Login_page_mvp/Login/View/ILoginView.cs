using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.View
{
    internal interface ILoginView
    {


        event EventHandler Exit;
        event EventHandler<string> leaveTextBox;
        event EventHandler<bool> clickTextBox;
        void UpdateUI();

    }
}