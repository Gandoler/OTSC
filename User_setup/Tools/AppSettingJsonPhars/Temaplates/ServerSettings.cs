using Serilog;

namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    public class ServerSettings : Itemplates
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string GetConnectionString()
        {
            if (string.IsNullOrWhiteSpace(Server) ||
                string.IsNullOrWhiteSpace(Database) ||
                string.IsNullOrWhiteSpace(User) ||
                string.IsNullOrWhiteSpace(Password))
            {
                Log.Information("ServerSettings: now in template:" + this.ToString());
                Log.Error("ServerSettings:One or more required fields are missing for the connection string.");
               
            }
            
            return $"Server={Server};Port={Port};Database={Database};User Id={User};Password={Password};";
        }
        public override string ToString()
        {
            return $"{Server?.ToString()}, {Port.ToString()}, {Database?.ToString()}, {User?.ToString()}, {Password?.ToString()}";
        }
    }
}
