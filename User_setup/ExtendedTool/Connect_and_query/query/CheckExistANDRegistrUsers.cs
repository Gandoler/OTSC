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
        public static bool CheckOFExistUser(MySqlConnection connection,long login,string psw)
        {
            string query = "SELECT COUNT(*) FROM UsersLogin WHERE Login = @login and Password = @psw;";
            try
            {
                using var query_command = new MySqlCommand(query, connection);
                query_command.Parameters.AddWithValue("@login", login);
                query_command.Parameters.AddWithValue("@psw", psw);
                var result = query_command.ExecuteNonQuery();
                return Convert.ToInt32(result) == 1;
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

        public static bool RegistrUser(MySqlConnection connection, long login, string psw, string email)
        {

            if (CheckOFExistUser(connection, login, psw))
            {
                MessageBox.Show("User exist already", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string query = "INSERT INTO UsersLogin (Login, Password, Email) VALUES (@login, @psw, @email);";
            try
            {
                using var query_command = new MySqlCommand(query, connection);
                query_command.Parameters.AddWithValue("@login", login);
                query_command.Parameters.AddWithValue("@psw", psw);
                query_command.Parameters.AddWithValue("@email", email);
                int rowsAdd = query_command.ExecuteNonQuery();
                return rowsAdd > 0;
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
