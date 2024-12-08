using OTSC_ui.DBTools.Connection;
using OTSC_ui.DBTools.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.DBTools
{
    internal class DataManager
    {
        private readonly IConnectManager _connectManager;
        private readonly ISqlOperation _sqlOperation;
        public DataManager(IConnectManager ConnectManager, ISqlOperation SqlOperation) { 
            _connectManager = ConnectManager;
            _sqlOperation = SqlOperation;
        }

        public void InsertData(string query)
        {

        }


        public void UpdateData(string query) 
        { 
        
        }

        public void DeleteData(string query) 
        {

        }

        public void GetDataTable(string query) 
        {

        }


    }
}
