using OTSC_ui.AppSettingJsonPhars.Temaplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.AppSettingJsonPhars.Reader
{
    internal class JsonReader : IJsonReader
    {
        public T Read<T>(string filePath) where T : Itemplates
        {
            throw new NotImplementedException();
        }
    }
}
