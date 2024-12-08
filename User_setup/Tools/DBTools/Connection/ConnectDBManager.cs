using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Serilog;

namespace OTSC_ui.Tools.DBTools.Connection
{
    internal class ConnectDBManager : IConnectManager
    {
        private readonly string _connectionString;
        private MySqlConnection? _connection;

        public MySqlConnection? SqlConnection
        {
            get
            {
                if (_connection != null)
                {
                    return _connection;
                }
                else
                {
                    Connect();
                    return _connection;
                }
            }
        }

        public ConnectDBManager(string conectionString)
        {
            _connectionString = conectionString;
        }


        public void Connect()
        {
            _connection = new MySqlConnection(_connectionString);
            _connection.Open();
        }

        public void Disconnect()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}
