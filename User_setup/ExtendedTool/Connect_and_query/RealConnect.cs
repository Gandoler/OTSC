using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Interface.ExtendedTool.Connect_and_query
{




    internal  class RealConnect : IConnect
    {
        
        private string _connectionString="";


        public RealConnect()
        {
            CreateConnectionString();
        }



        public void CreateConnectionString()
        {
           
            string? connectionString = "";
            DBdata? dBdata = JSONReader.bdata();
            if (dBdata != null)
            {
                _connectionString =
                                 $"Server={(dBdata?.ip ?? "localhost")};" +
                                 $"Port={(dBdata?.PORT > 0 ? dBdata.PORT : 3306)};" +
                                 $"Database={(dBdata?.Database ?? "default_database")};" +
                                 $"User={(dBdata?.Username ?? "default_user")};" +
                                 $"Password={(dBdata?.PSW ?? "default_password")};";
            }
            else
            {
                MessageBox.Show("Problems with JSON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection connection;
            try
            {
                connection = new MySqlConnection(_connectionString);
                connection.Open();
                Console.WriteLine("Соединение успешно установлено!");
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка подключения: {ex.Message}");
            }
            throw new NotImplementedException();
        }

        
    }
}
