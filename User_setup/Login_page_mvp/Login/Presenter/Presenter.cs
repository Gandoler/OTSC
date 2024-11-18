using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.Login.Model;
using User_Interface.Login_page_mvp.View;


namespace User_Interface.Login_page_mvp.Login.Presenter
{
    internal class Presenter
    {
        private ILoginView _loginView;
        private Imodelka _imodelka;

        private string _password { get; set; }
        private string _secPassword { get; set; }
        private string _login { get; set; }
        private bool _theme { get; set; }

        internal Presenter(ILoginView loginView, Imodelka imodelka)
        {
            _loginView = loginView ?? throw new ArgumentNullException(nameof(loginView));
            _imodelka = imodelka ?? throw new ArgumentNullException(nameof(imodelka));

            _loginView.ExitApl += _loginView_Exit;
            _loginView.leaveLoginTextBox += LeaveLogin;
          
            _loginView.leavePasswordTextBox += LeavePassword;
            _loginView.leaveSecondPasswordTextBox += LeaveSecondPswAndCheck;
            _loginView.enter += enterButtonClicked;
            _loginView.show_Psw += View_show_Psw;

        }

        private void View_show_Psw(object? sender, bool e)
        {
            if (e)
            {
                _loginView.ShowPsw();
            }
            else{
                _loginView.UnShowPsw();
            }
        }

        private void enterButtonClicked(object? sender, EventArgs e)
        {
            if (_password.CompareTo(_secPassword) != 0)
            {
                _loginView.ClearPasswords();
                _loginView.ShowPasswordMismatchMessageBox("MSG MISMATCH");
                _loginView.BlockSecPsw();
            }
            
        }

        private void LeaveSecondPswAndCheck(object? sender, string e)
        {
            _secPassword = e;



        }

        private void LeavePassword(object? sender, string e)
        {
            _password = e;
            _loginView.UnBlockSecPsw();

        }

        private void LeaveLogin(object? sender, string e)
        {
            _login = e;
        }

        private void _loginView_Exit(object? sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
