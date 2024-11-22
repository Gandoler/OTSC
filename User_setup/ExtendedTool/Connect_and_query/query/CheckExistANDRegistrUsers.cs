using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.ExtendedTool.Connect_and_query.query
{
    internal static class CheckExistANDRegistrUsers
    {
        public static bool CheckOFExistUser(MySqlConnection connection,string login,string psw)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username and Password = @psw;";
            try
            {
                using (var query_command = new MySqlCommand(query, connection))
                {
                    query_command.Parameters.AddWithValue("@username", login);
                    query_command.Parameters.AddWithValue("@psw", psw);
                    var result = query_command.ExecuteNonQuery();
                    return Convert.ToInt32(result) == 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
         
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            throw new Exception("ERORR WITH CHECK YOU IN DB");//хз как грамотно эту ошибку дернуть

        }

        public static bool RegistrUser(MySqlConnection connection, string login, string psw)
        {

            if (CheckOFExistUser(connection, login, psw))
            {
                MessageBox.Show("User exist already", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string query = "INSERT INTO Users (Username, Password) VALUES (@username, @psw);";
            try
            {
                using (var query_command = new MySqlCommand(query, connection))
                {
                    query_command.Parameters.AddWithValue("@username", login);
                    query_command.Parameters.AddWithValue("@psw", psw);
                    int rowsAdd = query_command.ExecuteNonQuery();
                    return rowsAdd > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            throw new Exception("ERORR WITH ADD YOU IN DB");//хз как грамотно эту ошибку дернуть
        }

    }
}
