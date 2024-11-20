using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    internal interface IConnect
    {
        public string CreateConnectionString();
        public MySqlConnection GetConnection();



    }



    internal class RealConnect : IConnect
    {
        public string CreateConnectionString()
        {
            
        }

        public MySqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }


    internal  static class JSONReader
    {

        public static DBdata? bdata()
        {
            string filepath = pr;
            
            if (File.Exists(filepath))
            {
                try
                {
                    string jsonchikData = File.ReadAllText(filepath);
                    DBdata dBdata = JsonSerializer.Deserialize<DBdata>(jsonchikData);
                    return dBdata;
                }
                catch (SerializationException ex)
                {
                }
                catch (JsonException ex) { 
                }
                catch (Exception ex)
                {
                }
            }
            return null;
        }

    }


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
