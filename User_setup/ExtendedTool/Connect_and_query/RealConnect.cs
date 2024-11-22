using MySql.Data.MySqlClient;
using Serilog;
using User_Interface.ExtendedTool.Connect_and_query;

internal static class RealConnect
{
    private static readonly string _connectionString;
    private static MySqlConnection _connection;
    private static readonly object _lock = new();

    static RealConnect()
    {
        try
        {
            DBdata? dBdata = JSONReader.bdata();

            if (dBdata != null)
            {
                _connectionString =
                    $"Server={(dBdata.ip ?? "localhost")};" +
                    $"Port={(dBdata.PORT > 0 ? dBdata.PORT : 3306)};" +
                    $"Database={(dBdata.Database ?? "default_database")};" +
                    $"User={(dBdata.Username ?? "default_user")};" +
                    $"Password={(dBdata.PSW ?? "default_password")};";
            }
            else
            {
                MessageBox.Show("Problems with JSON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message, "Ошибка в {MethodName}", nameof(RealConnect));
            throw;
        }
    }

    public static MySqlConnection Connection
    {
        get
        {
            
            if (_connection == null || _connection.State != System.Data.ConnectionState.Open)
            {
                OpenConnection();
            }
            return _connection;
            
        }
    }

    private static void OpenConnection()
    {
        try
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection(_connectionString);
            }

            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
                string ChoiseDB = "USE Users";
                using var comand  =new MySqlCommand(ChoiseDB, _connection);
                comand.ExecuteNonQuery();
            }
        }
        catch (MySqlException ex)
        {
            Log.Error(ex.Message, "Ошибка подключения к базе данных:", nameof(OpenConnection));
            throw;
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message, "Ошибка подключения к базе данных:", nameof(OpenConnection));
            throw;
        }
    }

    public static void CloseConnection()
    {
        lock (_lock)
        {
            try
            {
                if (_connection?.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, "Ошибка отключения от базы данных:", nameof(CloseConnection));
                throw;
            }
        }
    }

    public static bool CheckConnectionAlive()
    {
        lock (_lock)
        {
            return _connection?.State == System.Data.ConnectionState.Open;
        }
    }
}
