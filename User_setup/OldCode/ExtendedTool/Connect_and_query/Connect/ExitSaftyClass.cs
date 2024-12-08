using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OTSC_ui.OldCode.ExtendedTool.Connect_and_query.Connect
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
