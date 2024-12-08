using Serilog;
using System.Text.Json;
using User_Interface.ExtendedTool;

namespace OTSC_ui.OldCode.ExtendedTool.Connect_and_query.Connect
{
    internal static class JSONReader
    {

        public static DBdata? bdata()
        {
            string filePath = Properties.Settings1.Default.Serverpath;

            Log.Information(filePath + "-filepath");
            if (File.Exists(filePath))
            {
                Log.Information(filePath + "-exist");
            }
            //этому методу нужна переработка


            if (filePath == null)
            {
                using (var inputForm = new CustomShowBox())
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        DBdata dBdata = inputForm.DBdata;
                        return dBdata;

                    }

                }
            }

            if (File.Exists(filePath))
            {

                try
                {
                    string jsonchikData = File.ReadAllText(filePath);
                    DBdata? dBdata = JsonSerializer.Deserialize<DBdata>(jsonchikData);
                    if (dBdata != null)
                    {
                        Log.Information("Successfully deserialized JSON data: {DBdata}", dBdata.ToString());
                        return dBdata;
                    }
                    Log.Warning("Deserialized DBdata is null.");
                }
                catch (JsonException ex)
                {
                    Log.Error("JSON deserialization error: {Message}", ex.Message);

                }
                catch (Exception ex)
                {
                    Log.Error("Unexpected error: {Message}", ex.Message);

                }
            }


            return null;
        }

    }
}