using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.ExtendedTool.Connect_and_query;

namespace User_setup
{
    public static class ExitSaftyClass
    {
        public static void AplicationExitSafety()
        {
            RealConnect.CloseConnection();
            Application.Exit();
        }
    }
}
