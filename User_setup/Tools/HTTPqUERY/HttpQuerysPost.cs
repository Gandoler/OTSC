using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.HTTPqUERY
{
    internal class HttpQuerysPost: IHttpQuerysPost
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = string.Empty;

        public HttpQuerysPost(HttpClient HttpClient, string Url)
        {
            _httpClient = HttpClient;
            _url = Url;
        }

        public async Task<int> SendTgCodeToTgAsync() => await MakePostQueryTelegram(Properties.Settings1.Default.ID);
        public async Task<int> SendTgCodeToTgAsync(long id) => await  MakePostQueryTelegram(id);


        private async Task<int> MakePostQueryTelegram(long id)
        {
            var verRequest = new VerificationRequest(id);
            var jsonContent = JsonConvert.SerializeObject(verRequest);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


            var response = await _httpClient.PostAsync(_url, content);
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

                    Log.Information($"Verification code received: {verificationResponse.Code}");
                    return verificationResponse.Code;
                }
                else
                {
                    // Обработка ситуации, если пользователь не подписан
                    Log.Information($"User is not subscribed to the bot");
                    MessageBox.Show("Вы ещё не подписались на бота. Пожалуйста, подпишитесь и повторите попытку.", "Подписка на бота", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
            }
            else
            {
                Log.Information($"Bad response in {nameof(SendTgCodeToTgAsync)}in  {nameof(HttpQuerysPost)}");
                throw new Exception($"Bad response in {nameof(SendTgCodeToTgAsync)}in  {nameof(HttpQuerysPost)}");

            }
        }





    }
}
