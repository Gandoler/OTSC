using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    internal  static class RealConnect 
    {

        private static readonly string _connectionString;
        private static MySqlConnection _connection;


        static RealConnect()
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


        public  static MySqlConnection GetConnection()
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
       

        public static async Task OpenConnectionAsync()
        {
            if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
            {
                _connection = GetConnection();
                await _connection.OpenAsync();
            }
        }

        public static void CloseConnection()
        {
            if (_connection?.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

    }
}
