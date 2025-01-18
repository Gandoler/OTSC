using Newtonsoft.Json;
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
    internal class MustSubscribeModel : IMustSubscribeModel
    {
        private readonly HttpClient _httpClient;
        public event Action? CodeCorrect;
        private int code;

        public MustSubscribeModel( HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void CheckCode(string Code)
        {
            CodeCorrect?.Invoke();
           
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
                Log.Error($"User cant go to link in {nameof(GoLink)} in {nameof(MustSubscribeModel)} exception:{ex.Message}");
            }
        }

        public async void SendCode()// пока как есть напишу потом над все грамотно вынести
        {
            string url = "http://localhost:5291/VerificationCode/";
            url += Properties.Settings1.Default.ID;

            var requestBody = new
            {
                username,
                telegramId = telegramId
            };

            var response = await _httpClient.GetAsync( url );
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonResponse)) 
                {
                    var verificationResponse = JsonConvert.DeserializeObject<requestBody>(jsonResponse);
                }

            }
            
        }

        public Task SendCodeToTelegram()
        {
            throw new NotImplementedException();
        }

        public void SendCode(string Code)
        {
            throw new NotImplementedException();
        }
    }
}
