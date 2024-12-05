using Serilog;
using System.Text.Json;
using User_Interface.ExtendedTool;

namespace OTSC_ui.ExtendedTool.Connect_and_query.Connect
{
    internal static class JSONReader
    {

        public static DBdata? bdata()
        {
            string filePath = Properties.Settings1.Default.Jsonpath;

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
                    return dBdata;
                }
                catch (JsonException ex)
                {
                    Log.Error(ex.Message, "Ошибка в {MethodName}", nameof(DBdata));
                    throw;
                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message, "Ошибка в {MethodName}", nameof(DBdata));
                    throw;
                }
            }


            return null;
        }

    }
}