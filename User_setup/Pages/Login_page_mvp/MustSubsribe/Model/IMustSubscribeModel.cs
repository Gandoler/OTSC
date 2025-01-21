using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model
{
    internal interface IMustSubscribeModel
    {

        event Action CodeCorrect;
        event Action CodeIncorect;



        void CheckCode(string Code);
        Task GetCodeHttp();

        void GoLink();
    }
}
