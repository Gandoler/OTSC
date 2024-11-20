using System.Text.Json.Serialization;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    internal class DBdata
    {
        [JsonPropertyName("IP")]
        private string _ip { get; init; }
        [JsonPropertyName("Username")]
        private string _Username { get; init; }
        [JsonPropertyName("PSW")]
        private string _PSW { get; init; }
        [JsonPropertyName("PORT")]
        private int _PORT { get; init; }

        internal DBdata(string ip, string Username, string PSW, int PORT)
        {
            _ip = ip;
            _Username = Username;
            _PSW = PSW;
            _PORT = PORT;
        }

    }
}
