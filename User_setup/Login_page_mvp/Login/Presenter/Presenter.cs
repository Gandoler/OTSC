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
        private string _login { get; set; }
        private bool _theme { get; set; }

        public Presenter(ILoginView _loginView, Imodelka _imodelka)
        {
            _loginView.ExitApl += _loginView_Exit;
            _loginView.leaveLoginTextBox += EnterLogin;
            
        }

        private void EnterLogin(object? sender, string e)
        {
            _login = e;
        }

        private void _loginView_Exit(object? sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
