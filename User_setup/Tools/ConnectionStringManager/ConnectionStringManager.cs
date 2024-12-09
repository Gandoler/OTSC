
using OTSC_ui.Tools.AppSettingJsonPhars.Reader;
using OTSC_ui.Tools.AppSettingJsonPhars.Temaplates;
using Serilog;

namespace OTSC_ui.Tools.ConnectionStringManager
{
    internal static class ConnectionStringManager
    {
        public static string? GetConnectionString()
        {
            RootConfig settings = new RootConfig();
            JsonReaderForConfig jsonReader = new JsonReaderForConfig();
            try
            {
                settings = jsonReader.Read<RootConfig>(Properties.Settings1.Default.AppsettingsPath);
                Log.Information($"ConnectionStringManager: settings:{settings.ToString()}");
            }
            catch (Exception ex) 
            {
                Log.Error($"In ConnectionStringManager {ex.Message}");
            }
            if (settings.ServerSettings != null)
            {  
                return settings.ServerSettings.GetConnectionString();
            }
            return null;
        }
    }
}
