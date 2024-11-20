using System.Runtime.Serialization;
using System.Text.Json;
using User_Interface.ExtendedTool;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    internal static class JSONReader
    {

        public static DBdata? bdata()
        {
            string filePath = Properties.Settings1.Default.Jsonpath;
            if (filePath == null )
            {
                using (var inputForm = new CustomShowBox())
                {
                    filePath = inputForm.FilePath;
                }
            }

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonchikData = File.ReadAllText(filePath);
                    DBdata dBdata = JsonSerializer.Deserialize<DBdata>(jsonchikData);
                    return dBdata;
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (JsonException ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
            return null;
        }

    }
}