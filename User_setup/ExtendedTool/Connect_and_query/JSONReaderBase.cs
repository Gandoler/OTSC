using System.Runtime.Serialization;
using System.Text.Json;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    internal static class JSONReader
    {

        public static DBdata? bdata()
        {
            string filepath = Properties.Settings1.Default.Jsonpath;

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
                catch (JsonException ex)
                {
                }
                catch (Exception ex)
                {
                }
            }
            return null;
        }

    }
}