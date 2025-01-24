using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.Http.Mail.Templates
{
    internal class ChangePassResponse
    {
        public bool ExistanceStatus { get; set; }
        public string Code { get; set; } = string.Empty;

        public ChangePassResponse(bool existanceStatus)
        {
            ExistanceStatus = existanceStatus;
        }

        public ChangePassResponse(string code)
        {
            ExistanceStatus = true;
            Code = code;
        }
    }
}
