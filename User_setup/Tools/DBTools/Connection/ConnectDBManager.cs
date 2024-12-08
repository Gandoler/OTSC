using MySql.Data.MySqlClient;
using Serilog;

namespace OTSC_ui.Tools.DBTools.Connection
{
    internal class ConnectDBManager : IConnectManager
    {
        private readonly string _connectionString;
        private MySqlConnection? _connection;

        public MySqlConnection? SqlConnection
        {
            get
            {
                if (_connection != null)
                {
                    return _connection;
                }
                else
                {
                    Connect();
                    return _connection;
                }
            }
        }

        public ConnectDBManager(string conectionString)
        {
            _connectionString = conectionString;
        }


        public void Connect()
        {
            _connection = new MySqlConnection(_connectionString);
            try
            {
                _connection.Open();
            }
            catch (MySqlException ex)
            {
                
                // Обработка MySQL исключений
                Log.Error("MySQL error occurred: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Обработка исключений, возникающих при некорректной операции
                Log.Error("Invalid operation: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Обработка всех остальных исключений
                Log.Error("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // Закрываем соединение, если оно было открыто
                if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                {
                    this.Disconnect();
                }
            }
        }

        public void Disconnect()
        {
            if (_connection != null)
            {
                try
                {
                    _connection.Close();
                }
                catch (MySqlException ex)
                {
                    // Обработка исключений, возникающих при закрытии соединения
                    Log.Error("An error occurred while closing the connection: " + ex.Message);
                }
                finally
                {
                    _connection = null;
                }
            }
        }
    }
}
