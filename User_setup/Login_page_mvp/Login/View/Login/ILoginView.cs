using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.Login.View.LOGIN
{
    internal interface ILoginView
    {
        string Login { get; }
        string Password { get; }
        


        event EventHandler ExitApl;
        event EventHandler<string> leavePasswordTextBox;
        //event EventHandler<string> leaveSecondPasswordTextBox;
        event EventHandler<string> leaveLoginTextBox;
        event EventHandler<bool> show_Psw;
        event EventHandler enter;
        event EventHandler<EventArgs> charKeyPresd;
        event EventHandler Registr_click;

        //void ShowPasswordMismatchMessageBox(string message); 
        //void ClearPasswords(); 
        //void BlockSecPsw();
        //void UnBlockSecPsw();

        void ShowPsw();
        void UnShowPsw();
        void NextPage();



    }
}