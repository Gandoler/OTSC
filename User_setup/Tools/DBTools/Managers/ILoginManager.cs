using OTSC_ui.Tools.DBTools.Connection;
using OTSC_ui.Tools.DBTools.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.DBTools.Managers
{
    internal interface ILoginManager
    {
        public bool Login(long login, string passwoerd);
        public bool Registr(long login, string email, string password);
        public bool ChangePassword(string password);
        public void Dispose();
    }
}
