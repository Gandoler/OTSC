using OTSC_ui.Tools.DBTools.Managers.Login;
using Serilog;

namespace OTSC_ui.Pages.Login_page_mvp.Login_page.Model
{
    internal class ModelLogin : ImodelLogin
    {
        private readonly ILoginManager _loginManager;
        private long _login;
        private string _password = string.Empty;
        private string _email = string.Empty;

        public ModelLogin(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        public event Action? LoginGo;
        public event Action? LogMismatch;
        public event Action? UserExist;
        public event Action? UserRegistered;
        public event EventHandler<string>? LoginFailed;
        public event EventHandler<string>? UserNotRegistered;

        //public event Action UserExist;

        public long Login
        {
            set
            {
                _login = value;
            }
        }


        public string Password
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Log.Error("bad Set password  in ModelLotgin");
                    ArgumentNullException argumentNullException = new(nameof(_login));
                    throw argumentNullException;
                }
                else
                {
                    _password = value;
                }


            }
        }

        public string Email
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Log.Error("bad Set Email  in ModelLotgin");
                    ArgumentNullException argumentNullException = new(nameof(_login));
                    throw argumentNullException;
                }
                else
                {
                    _email = value;
                }


            }
        }


        public void LogInApl()
        {
            try
            {
                if (_loginManager.Login(_login, _password))
                {
                    Properties.Settings1.Default.ID = _login;// вот тут запись айди
                    LoginGo?.Invoke();
                }
                else
                {
                    LogMismatch?.Invoke();
                }
            }
            catch (Exception exception) {
                LoginFailed?.Invoke(this, exception.Message);
            }

        }

        public void Registr()
        {
            try
            {
                if (_loginManager.Registr(_login, _email, _password)){
                    Properties.Settings1.Default.ID = _login;
                    UserRegistered?.Invoke();
                }
                else
                {
                    UserExist?.Invoke();
                }
            }
            catch (Exception ex)
            {
                UserNotRegistered?.Invoke(this, ex.Message);
                Log.Error($"Erorr in LoginModel  :{ex.Message}");
            }
        }
    }
}
