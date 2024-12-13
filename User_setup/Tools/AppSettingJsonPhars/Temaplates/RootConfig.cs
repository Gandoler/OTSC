using Newtonsoft.Json;

namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    internal class RootConfig : Itemplates
    {
        [JsonProperty("serverSetings")] // Укажите правильное имя из JSON
        public ServerSettings ServerSettings { get; set; } = new ServerSettings();

        [JsonProperty("emailSetings")]
        public EmailSettings EmailSettings { get; set; } = new EmailSettings();

        [JsonProperty("botSettings")]
        public BotSettings BotSettings { get; set; }  =new BotSettings();

        public string GetConnectionString()
        {
            return EmailSettings?.ToString() + ServerSettings?.ToString();
        }
        public override string ToString()
        {
            return EmailSettings?.ToString() + ServerSettings?.ToString();
        }

    }
}
