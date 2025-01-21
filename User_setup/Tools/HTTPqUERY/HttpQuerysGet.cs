using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.HTTPqUERY
{
    internal class HttpQuerysGet: IHttpQuerysGet
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = string.Empty;

        public HttpQuerysGet(HttpClient HttpClient, string Url)
        {
            _httpClient = HttpClient;
            _url = Url;
        }

        public async Task<int> SendTgCodeToTgAsync()
        {

            string url = _url + "VerificationCode/";
            url += Properties.Settings1.Default.ID.ToString();



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
                   
                    Log.Information($"Verification code received: {verificationResponse.Code}");
                    return verificationResponse.Code;
                }
                else
                {
                    // Обработка ситуации, если пользователь не подписан
                    Log.Information($"User is not subscribed to the bot");
                    return -1;
                }
            }
            else
            {
                Log.Information($"Bad response in {nameof(SendTgCodeToTgAsync) }in  {nameof(HttpQuerysGet)}");
                throw new Exception($"Bad response in {nameof(SendTgCodeToTgAsync)}in  {nameof(HttpQuerysGet)}");

            }
        }


        public async Task<int> SendTgCodeToTgAsync(long id)
        {

            string url = _url + "VerificationCode/";
            url += id;



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
                Log.Information($"Bad response in {nameof(SendTgCodeToTgAsync)}in  {nameof(HttpQuerysGet)}");
                throw new Exception($"Bad response in {nameof(SendTgCodeToTgAsync)}in  {nameof(HttpQuerysGet)}");

            }
        }


    }
}
