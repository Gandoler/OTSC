using Newtonsoft.Json;
using OTSC_ui.Tools.AppSettingJsonPhars.Temaplates;
using Serilog;


namespace OTSC_ui.Tools.AppSettingJsonPhars.Reader
{
    internal class JsonReader : IJsonReader
    {
        public T Read<T>(string filePath) where T : Itemplates
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File not found: {filePath}");

                string jsonContent = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(jsonContent) ?? throw new JsonException("empty or bad file");
            }
            catch (Exception ex)
            {
                Log.Error($"Error reading JSON file: {ex.Message}");
                throw;
            }
        }
    }
}
