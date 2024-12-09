
using OTSC_ui.Tools.AppSettingJsonPhars.Reader;
using OTSC_ui.Tools.AppSettingJsonPhars.Temaplates;
using Serilog;

namespace OTSC_ui.Tools.ConnectionStringManager
{
    internal static class ConnectionStringManager
    {
        public static string GetConnectionString()
        {
            ServerSettings settings = new ServerSettings();
            JsonReaderForConfig jsonReader = new JsonReaderForConfig();
            try
            {
                settings = jsonReader.Read<ServerSettings>(Properties.Settings1.Default.AppsettingsPath);
            }
            catch (Exception ex) 
            {
                Log.Error($"In ConnectionStringManager {ex.Message}");
            }
            return settings.GetConnectionString();
        }
    }
}
