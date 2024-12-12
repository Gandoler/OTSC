using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model
{
    internal class MustSubscribeModel : IMustSubscribeModel
    {
        public event Action? CodeCorrect;


        public MustSubscribeModel()
        {

        }

        public void CheckCode(string Code)
        {
            throw new NotImplementedException();
        }

        public void GoLink()
        {
            string url = Properties.Settings1.Default.TelegramBot;
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                Log.Information($"User go to link {url}");
            }
            catch (Exception ex) {
                Log.Error($"User cant go to link in {nameof(GoLink)} in {nameof(MustSubscribeModel)}");
            }
        }

        public void SendCode(string Code)
        {
            throw new NotImplementedException();
        }

        public Task SendCodeToTelegram()
        {
            throw new NotImplementedException();
        }
    }
}
