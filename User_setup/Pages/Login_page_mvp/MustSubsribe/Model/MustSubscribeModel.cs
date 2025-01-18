using Microsoft.Extensions.Logging;
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
    public class MustSubscribeModel : IMustSubscribeModel
    {
        private readonly HttpClient _httpClient;
        public event Action? CodeCorrect;
        public event Action? CodeIncorect;

        private int code;


        public MustSubscribeModel( HttpClient httpClient)
        {
            _httpClient = httpClient;
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
            string url = "http://localhost:5291/VerificationCode/";
            url += Properties.Settings1.Default.ID.ToString();

            

            var response = await _httpClient.GetAsync( url );
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var verificationResponse = new VerificationResponse();
                if (!string.IsNullOrEmpty(jsonResponse))
                {
                    verificationResponse = JsonConvert.DeserializeObject<VerificationResponse>(jsonResponse);
                }

                if (verificationResponse != null && verificationResponse.IsSubscribed)
                {
                    this.code = verificationResponse.Code;
                    Log.Information($"Verification code received: {this.code}");
                }
                else
                {
                    // Обработка ситуации, если пользователь не подписан
                    Log.Information($"User is not subscribed to the bot");
                    MessageBox.Show("Вы ещё не подписались на бота. Пожалуйста, подпишитесь и повторите попытку.", "Подписка на бота", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Log.Information($"Bad response in {nameof(GetCodeHttp)}");
                
            }
        }

        public async Task GetCode(long id)// пока как есть напишу потом над все грамотно вынести
        {
            string url = "http://localhost:5291/VerificationCode/";
            url += id.ToString();



            var response = await _httpClient.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var verificationResponse = new VerificationResponse();
                if (!string.IsNullOrEmpty(jsonResponse))
                {
                    verificationResponse = JsonConvert.DeserializeObject<VerificationResponse>(jsonResponse);
                }

                if (verificationResponse != null && verificationResponse.IsSubscribed)
                {
                    this.code = verificationResponse.Code;
                    Log.Information($"Verification code received: {this.code}");
                }
                else
                {
                    // Обработка ситуации, если пользователь не подписан
                    Log.Information($"User is not subscribed to the bot");
                    MessageBox.Show("Вы ещё не подписались на бота. Пожалуйста, подпишитесь и повторите попытку.", "Подписка на бота", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Log.Information($"Bad response in {nameof(GetCodeHttp)}");

            }
        }

    }
}
