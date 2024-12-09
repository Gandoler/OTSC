using OTSC_ui.OldCode.ExtendedTool.Connect_and_query.query;
using OTSC_ui.Tools.DBTools.Managers;
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

        public string Login
        {

            set
            {
                long tmp;
                try
                {
                    tmp = long.Parse(value);
                }
                catch (Exception exception)
                {
                    Log.Error("bad Pharse Long from string in ModelLotgin");
                    throw new Exception("Bad pharse" + exception.Message);
                }
                if (tmp <= 0)
                {
                    Log.Error("bad Pharse Long from string in ModelLotgin");
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    _login = tmp;
                }
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



        public void LogInApl()
        {
            try
            {
                if (_loginManager.Login(_login, _password))
                {
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
                    LoginGo?.Invoke();
                }
                else
                {
                    LogMismatch?.Invoke();
                }
            }
            catch (Exception ex)
            {
                UserNotRegistered?.Invoke(this, ex.Message);
            }
        }


    }
}
