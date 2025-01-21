using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OTSC_ui.Tools.HTTPqUERY;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model
{
    public class MustSubscribeModel : IMustSubscribeModel
    {
       
        private readonly IHttpQuerysGet httpQuerysGet;
        public event Action? CodeCorrect;
        public event Action? CodeIncorect;

        private int code;


        public MustSubscribeModel(IHttpQuerysGet httpQuerysGet)
        {
            this.httpQuerysGet = httpQuerysGet;
        }

        public void CheckCode(string Code)
        {
            if (Code.Equals(code.ToString()))
            {
                CodeCorrect?.Invoke();
            }
            else{
                CodeIncorect?.Invoke();
            }
           
        }

        public async void GoLink()
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
                Log.Error($"User cant go to link in {nameof(GoLink)} in {nameof(MustSubscribeModel)} exception:{ex.Message}");
            }
        }

        public async Task GetCodeHttp()// пока как есть напишу потом над все грамотно вынести
        {
            int i = await httpQuerysGet.SendTgCodeToTgAsync();
            if (i != 0)
            {
                this.code = i;
            }
            else
            {
                MessageBox.Show("Вы ещё не подписались на бота. Пожалуйста, подпишитесь и повторите попытку.", "Подписка на бота", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task GetCode(long id)// пока как есть напишу потом над все грамотно вынести
        {
            int i = await httpQuerysGet.SendTgCodeToTgAsync(id);
            if (i != 0)
            {
                this.code = i;
            }
            else
            {
                MessageBox.Show("Вы ещё не подписались на бота. Пожалуйста, подпишитесь и повторите попытку.", "Подписка на бота", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
