using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.ExtendedTool.Connect_and_query;

namespace OTSC_ui.Login_page_mvp.Login_page.Model
{
    internal interface ImodelLogin
    {
        string Login { set; }
        string Password { set; }


        internal void LogInApl();

        event Action LoginGo;
        event Action LogMismatch;

    }
}
