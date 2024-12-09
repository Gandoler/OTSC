using OTSC_ui.OldCode.ExtendedTool.Connect_and_query.Connect;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr;
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



            #region LoginPageConstr
            //login page
            _loginView = loginView ?? throw new ArgumentNullException(nameof(loginView));


            // Exit button
            _loginView.ExitButtonClick += _loginView_ExitButtonClick;
            _loginView.ExitButtonEntered += _loginView_ExitButtonEntered;
            _loginView.ExitButtonLeavd += _loginView_ExitButtonLeavd;


            // Show password button
            _loginView.Show_PswButtonClick += _loginView_Show_PswButtonClick;

            // Login button
            _loginView.LoginButtonClick += _loginView_LoginButtonClick;

            // Resgistr button
            _loginView.RegistrButtonClick += _loginView_RegistrButtonClick;

            // Forgot password
            _loginView.ForgotPassworLinkClick += _loginView_ForgotPassworLinkClick;
            #endregion

            #region RegistrpageConstr
            // Exit button
            _registrView.ExitButtonClick += _registrView_ExitButtonClick;
            _registrView.ExitButtonEntered += _registrView_ExitButtonEntered;
            _registrView.ExitButtonLeavd += _registrView_ExitButtonLeavd;

            // Resgistr button
            _registrView.RegistrButtonClick += _registrView_RegistrButtonClick;

            //back button
            _registrView.GoBackButtonClick += _registrView_GoBackButtonClick;

            //email field button
            _registrView.LeaveEmailBoxAndCheckCorrect += _registrView_LeaveEmailBoxAndCheckCorrect;

            //for all field EXCEPT email
            _registrView.EnterInField += _registrView_EnterInField;
            _registrView.TextChengedInFieldExceptEmail += _registrView_TextChengedInFieldExceptEmail;

        #endregion
    }







        #region RegistrPage
        // Exit button
        private void _registrView_ExitButtonClick()
        { 
                Application.Exit();
        }
        private void _registrView_ExitButtonLeavd()
        {
            _registrView.MakeExitButtonForeBlack();
        }

        private void _registrView_ExitButtonEntered()
        {
            _registrView.MakeExitButtonForeRed();
        }


        // Resgistr button
        private void _registrView_RegistrButtonClick()
        {
            if (_registrView.CheckForAllFieldsNotEmpty())
            {
                //model do this
                ////
                ///
                ///////
            }
        }



        //back button
        private void _registrView_GoBackButtonClick()
        {
            Form? thisform = _registrView as Form;
            if (thisform != null)
            {
                thisform.Close();
            }
        }

        //email field 
        private void _registrView_LeaveEmailBoxAndCheckCorrect(object? sender, string e)
        {
            if (_registrView.CheckCorrectInputEmail())
            {
                _registrView.MakeNotVisibleEmailerror();
                _registrView.makeRegistrButtonEnable();
            }
            else
            {
                _registrView.MakeVisibleEmailerror();
            }
        }
        
        
        //for all field EXCEPT email
        private void _registrView_EnterInField()
        {
            _registrView.makeRegistrButtonDisable();
        }
        private void _registrView_TextChengedInFieldExceptEmail()
        {
            if (_registrView.CheckForAllFieldsNotEmpty())
            {
                _registrView.makeRegistrButtonEnable();
            }
        }
        #endregion

        #region LoginPage

        // Exit button
        private void _loginView_ExitButtonLeavd()
        {
            _loginView.MakeExitButtonForeBlack();
        }

        private void _loginView_ExitButtonEntered()
        {
            _loginView.MakeExitButtonForeRed();
        }

        private void _loginView_ExitButtonClick()
        {
            Application.Exit();
        }

        // Show password button
        private void _loginView_Show_PswButtonClick(object? sender, bool e)
        {
            if (e)
            {
                _loginView.ShowPsw();
            }
            else
            {
                _loginView.HidePsw();
            }
        }


        // Login button
        private void _loginView_LoginButtonClick(object? sender, (string, string) e)
        {
            (_imodelka.Login, _imodelka.Password) = e;
            _imodelka.LogInApl();
        }


        // Resgistr button
        private void _loginView_RegistrButtonClick()
        {
            Form? thisform = _loginView as Form;
            if (thisform != null)
            {
                Form? nextform = _registrView as Form;
                if (nextform != null)
                {
                    thisform.Hide();
                    nextform.Show();

                    //when user clode Registr Form
                    thisform.Show();
                }
            }
        }

        // Forgot password
        private void _loginView_ForgotPassworLinkClick()
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
        #endregion

    }
        
}
