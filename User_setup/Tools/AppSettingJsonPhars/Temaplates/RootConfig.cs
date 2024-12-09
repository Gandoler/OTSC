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
        [JsonProperty("serverSetings")]
        public EmailSettings? EmailSettings { get; set; }
        [JsonProperty("emailSetings")]
        public ServerSettings? ServerSettings { get; set; }

        public string GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}
