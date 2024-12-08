using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTSC_ui.AppSettingJsonPhars.Temaplates;

namespace OTSC_ui.AppSettingJsonPhars.Reader
{
    internal interface IJsonReader
    {
        T Read<T>(string filePath) where T : Itemplates;
    }
}
