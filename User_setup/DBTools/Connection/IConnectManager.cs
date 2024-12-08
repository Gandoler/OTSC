using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace OTSC_ui.DBTools.Connection
{
    internal interface IConnectManager
    {
        void Connect();
        void Disconnect();
        MySqlConnection? SqlConnection { get; }

        static abstract explicit operator MySqlConnection(IConnectManager v);
    }
}
