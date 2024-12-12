using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.Login_page.MustSubsribe
{
    internal interface IMustSubscribeView
    {

        event Action LinkClick;
        event EventHandler<EventArgs> CodeFieldText;
        event Action CodeEnterButton;

    }
}
