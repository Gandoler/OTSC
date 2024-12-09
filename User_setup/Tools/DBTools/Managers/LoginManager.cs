using OTSC_ui.Tools.DBTools.Connection;
using OTSC_ui.Tools.DBTools.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.DBTools.Managers
{
    internal class LoginManager: ILoginManager
    {
        private readonly IConnectManager _connectManager;
        public LoginManager(IConnectManager ConnectManager) 
        {
            _connectManager = ConnectManager;
            _connectManager.Connect();
        }

        public void Login(long login, string passwoerd) 
        {
            string query = $"SELECT * FROM Users WHERE "
            
        }


        public void Registr(long login, string email, string passwoerd)
        {

        }


        public void Dispose()
        {
            _connectManager.Disconnect();
        }


    }
}
