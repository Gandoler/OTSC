using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    internal class BotSettings : Itemplates
    {
        [JsonProperty("token")]
        public string BotToken { get; set; } = string.Empty;


        public string GetConnectionString()
        {
           return BotToken;
        }
    }
}
