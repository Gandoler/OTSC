using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.HTTPqUERY.Tempates
{
    internal class ChangePassRequest
    {
        public string Email { get; set; } = String.Empty;



        public ChangePassRequest(string Email)
        {
            this.Email = Email;
        }
    }
}
