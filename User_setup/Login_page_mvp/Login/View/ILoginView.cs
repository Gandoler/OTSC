using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.View
{
    internal interface ILoginView 
    {


        event EventHandler ExitApl;
        event EventHandler<string> leavePasswordTextBox;
        event EventHandler<string> leaveSecondPasswordTextBox;
        event EventHandler<string> leaveLoginTextBox;
        event EventHandler<bool> clickTextBox;

    }
}