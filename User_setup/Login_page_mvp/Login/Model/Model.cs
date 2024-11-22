using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.ExtendedTool.Connect_and_query;
using User_Interface.ExtendedTool.Connect_and_query.query;

namespace User_Interface.Login_page_mvp.Login.Model
{
    internal class Model : Imodelka
    {
        private long _login;
        private string? _password;
        private string? _email;

        public event Action loginGo;
        public event Action logMismatch;
        public event Action UserExist;

        public long Login
        {
            
            set {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    _login = value;
                }
            }
        }


        public string Password
        {
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_login));
                }
                else
                {
                    _password = value;
                }


            }
        }

        public string Email {
           
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_email));
                }
                else
                {
                    _email = value;
                }


            }
        }

       
      

       

        public void CloseConnection()
        {
            RealConnect.CloseConnection();
        }

        public void LogIn()
        {
            try
            {
                
                
                if (CheckExistANDRegistrUsers.CheckOFExistUser(RealConnect.Connection, _login, _password??throw new Exception("Bad Password")))
                {
                    Properties.Settings1.Default.ID = _login;
                    loginGo.Invoke();
                }
                else
                {
                    logMismatch.Invoke();
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок в случае проблем с подключением
                MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при подключении: {ex.Message}");
            }

        }

        public void Regisrt()
        {
            try
            {

                
                if (CheckExistANDRegistrUsers.RegistrUser(RealConnect.Connection, _login, _password ?? throw new Exception("Bad Password"), _email ?? throw new Exception("Bad Email")))
                {
                    Properties.Settings1.Default.ID = _login;
                    loginGo.Invoke();
                }
                else
                {
                    logMismatch.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при подключении: {ex.Message}");
            }
        }

        
    }
}
