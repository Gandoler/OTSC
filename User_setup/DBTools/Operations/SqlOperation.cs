using MySql.Data.MySqlClient;
using OTSC_ui.DBTools.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.DBTools.Operations
{
    internal class SqlOperation : ISqlOperation
    {
        private readonly IConnectManager _connectManager;
        SqlOperation(IConnectManager ConnectManager)
        {
            _connectManager = ConnectManager;
        }


        public void Delete(string query)
        {
            ExecuteQuery(query);
        }

        public void Insert(string query)
        {
            ExecuteQuery(query);
        }

        public void Select(string query, out DataTable results)
        {
            results = new DataTable();
            using (var command = new MySqlCommand(query, _connectManager.SqlConnection))
            using (var adapter = new MySqlDataAdapter(command))
            {
                adapter.Fill(results);
            }
        }

        public void Update(string query)
        {
            ExecuteQuery(query);
        }

        private void ExecuteQuery(string query)
        {
            using( var command = new MySqlCommand(query, _connectManager.SqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
