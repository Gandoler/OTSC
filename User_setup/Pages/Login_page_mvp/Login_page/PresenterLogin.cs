using Microsoft.Win32;
using OTSC_ui.OldCode.ExtendedTool.Connect_and_query.Connect;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.ForgotPasswordPage.View;


namespace OTSC_ui.Pages.Login_page_mvp.Login_page
{
    internal class PresenterLogin
    {
        private ILoginView _loginView;
        private ImodelLogin _imodelka;
        private IRegistrView _registrView;

        internal PresenterLogin(ILoginView loginView, ImodelLogin imodelka, IRegistrView registrView)
        {
            _loginView = loginView ?? throw new ArgumentNullException(nameof(loginView));
            _imodelka = imodelka ?? throw new ArgumentNullException(nameof(imodelka));
            _registrView = registrView ?? throw new ArgumentNullException(nameof(registrView));

            //обработчик для вьювера
            // for forgot password
            _loginView.ForgotPassworLinkClick += _loginView_forgotPassworLinkClick;
            _loginView.ExitApl += LoginView_Exit;
            _loginView.ErnterInField += EnterButtonClicked;
            _loginView.Show_Psw += View_show_Psw;
            _loginView.CharKeyPresd += OnlyEnglishCheck;
            _loginView.Registr_click += Registr_click;

            //обработчик для модели
            _imodelka.LogMismatch += _imodelka_LogMismatch;
            _imodelka.LoginGo += _imodelka_LoginGo;

        }

        //обработчик для вьювера
        private void _loginView_forgotPassworLinkClick()
        {
            Form? thisform = _loginView as Form;
            if (thisform != null)
            {
                ChangePasswordFormForm changePasswordFormForm = new ChangePasswordFormForm();
                EmailEnterfrom emailEnterfrom = new EmailEnterfrom();
                ModelForgorPasswordPage modelForgorPasswordPage = new ModelForgorPasswordPage();
                PresenterForgotPasswoedPage presenterForgotPasswoedPage = new PresenterForgotPasswoedPage(modelForgorPasswordPage, changePasswordFormForm, emailEnterfrom);
                thisform.Hide();
                DialogResult result = emailEnterfrom.ShowDialog();//можно конечно что то делать но бог с ним

                thisform.Show();
            }
        }




        /// <summary>
        /// затычка
        /// </summary>
        private void _imodelka_LoginGo()
        {
            MessageBox.Show("You ENTER", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _imodelka_LogMismatch()
        {
            _loginView.ClearAll();
            MessageBox.Show("LOGIN OR PASSWORD MISMATCH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Registr_click(object? sender, EventArgs e)
        {
            _loginView.NextPage();
        }

        private void OnlyEnglishCheck(object? sender, EventArgs e)
        {
            var label = sender as Label;


            if (e is KeyPressEventArgs args)
            {


                if (!(char.IsDigit(args.KeyChar) || char.IsControl(args.KeyChar)))
                {

                    args.Handled = true;
                    if (label is not null)
                        label.Visible = true;

                }
                else
                {
                    if (label is not null)
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
            else
            {
                _loginView.UnShowPsw();
            }
        }

        private void EnterButtonClicked(object? sender, EventArgs e)
        {

            (_imodelka.Login, _imodelka.Password) = _loginView.CopyUserLogin();
            _imodelka.LogInApl();
        }






        private void LoginView_Exit(object? sender, EventArgs e)
        {
            ExitSaftyClass.AplicationExitSafety();
        }

    }
}
