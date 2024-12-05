using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.Login_page.View
{
    internal interface ILoginView
    {
        string Login { get; }
        string Password { get; }



        event EventHandler ExitApl;
        event EventHandler<bool> Show_Psw;
        event EventHandler ErnterInField;
        event EventHandler<EventArgs> CharKeyPresd;
        event EventHandler Registr_click;

        // for forgot password
        event Action ForgotPassworLinkClick;

        void ShowPsw();
        void UnShowPsw();
        void NextPage();
        void ClearAll();
        (string, string) CopyUserLogin();



    }
}