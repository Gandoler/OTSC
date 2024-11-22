using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.ExtendedTool.Connect_and_query;

namespace User_Interface.Login_page_mvp.Login.Model
{
    internal interface IModelka
    {
        long Login { set; }
        string Password {  set; }
        string Email {  set; }

        internal void CloseConnection();
        
        internal void LogIn();
        internal void Regisrt();

        event Action LoginGo;
        event Action LogMismatch;
        event Action UserExist;
    }
}
