using System.Text.Json.Serialization;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    public class DBdata
    {
        [JsonPropertyName("IP")]
        public string ip { get; init; }
        [JsonPropertyName("Username")]
        public string Database { get; init; }
        [JsonPropertyName("Database")]
        public string Username { get; init; }
        [JsonPropertyName("PSW")]
        public string PSW { get; init; }
        [JsonPropertyName("PORT")]
        public int PORT { get; init; }

        public DBdata(string ip, string Username, string Database, string PSW, int PORT)
        {
            this.ip = ip;
            this.Database = Username;
            this.Username = Database;
            this.PSW = PSW;
            this.PORT = PORT;
        }

    }
}
