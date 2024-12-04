using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.ExtendedTool.Connect_and_query;

namespace OTSC_ui.ExtendedTool.Connect_and_query.Connect
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
