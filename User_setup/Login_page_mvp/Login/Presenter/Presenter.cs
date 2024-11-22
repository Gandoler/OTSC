using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.Login.Model;
using User_Interface.Login_page_mvp;
using User_Interface.Login_page_mvp.Login.View.Registr;
using User_Interface.Login_page_mvp.Login.View;

namespace User_Interface.Login_page_mvp.Login.Presenter
{
    internal class Presenter
    {
        private ILoginView _loginView;
        private IModelka _imodelka;
        private IRegistrView _registrView;

        private string Password { get; set; }
        private string SecPassword { get; set; }
        private string Login { get; set; }
        //private bool Theme { get; set; }

        internal Presenter(ILoginView loginView, IModelka imodelka, IRegistrView registrView)
        {
            _loginView = loginView ?? throw new ArgumentNullException(nameof(loginView));
            _imodelka = imodelka ?? throw new ArgumentNullException(nameof(imodelka));
            _registrView = registrView ?? throw new ArgumentNullException(nameof(imodelka));

            _loginView.ExitApl += LoginView_Exit;
            _loginView.LeaveLoginTextBox += LeaveLogin;
          
            _loginView.LeavePasswordTextBox += LeavePassword;
            //_loginView.leaveSecondPasswordTextBox += LeaveSecondPswAndCheck;
            _loginView.Enter += EnterButtonClicked;
            _loginView.Show_Psw += View_show_Psw;
            _loginView.CharKeyPresd += OnlyEnglishCheck;
            _loginView.Registr_click += Registr_click;

        }

        private void Registr_click(object? sender, EventArgs e)
        {
            _loginView.NextPage();
        }

        private void OnlyEnglishCheck(object? sender, EventArgs e)
        {
            var label  = sender as Label;


            if (e is KeyPressEventArgs args)
            {


                if (!(Char.IsDigit(args.KeyChar) || Char.IsControl(args.KeyChar)))
                {

                    args.Handled = true;
                    label.Visible = true;

                }
                else
                {
                    label.Visible = false;
                }


            }


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

        private void EnterButtonClicked(object? sender, EventArgs e)
        {

           
            
        }

        private void LeaveSecondPswAndCheck(object? sender, string e)
        {
            SecPassword = e;
        }

        private void LeavePassword(object? sender, string e)
        {
            Password = e;
            //if (e.Length > 0)
            //{
            //    _loginView.UnBlockSecPsw();
            //}
        }

        private void LeaveLogin(object? sender, string e)
        {
            Login = e;
        }

        private void LoginView_Exit(object? sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
