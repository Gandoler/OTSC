using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    internal class RootConfig : Itemplates
    {
        [JsonProperty("serverSetings")] // Укажите правильное имя из JSON
        public ServerSettings ServerSettings { get; set; }

        [JsonProperty("emailSetings")]
        public EmailSettings EmailSettings { get; set; }

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
