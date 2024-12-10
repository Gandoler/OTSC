using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.DBTools.Managers.ForgotPSW
{
    internal interface IForgotpasswordManager
    {
        public bool ChangePassword(string password, string email);
        public bool CheckUserExist(string email);
        public void Dispose();
    }
}
