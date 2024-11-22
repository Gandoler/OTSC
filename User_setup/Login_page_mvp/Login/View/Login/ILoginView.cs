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
        event EventHandler<string> LeavePasswordTextBox;
        //event EventHandler<string> leaveSecondPasswordTextBox;
        event EventHandler<string> LeaveLoginTextBox;
        event EventHandler<bool> Show_Psw;
        event EventHandler Enter;
        event EventHandler<EventArgs> CharKeyPresd;
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