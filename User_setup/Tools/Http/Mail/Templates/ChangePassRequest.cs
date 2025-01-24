using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.Http.Mail.Templates
{
    internal class ChangePassRequest
    {
        public string Email { get; set; } = string.Empty;



        public ChangePassRequest(string Email)
        {
            this.Email = Email;
        }
    }
}
