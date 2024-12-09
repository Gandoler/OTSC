using OTSC_ui.OldCode.ExtendedTool.Connect_and_query.Connect;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr;
using OTSC_ui.Tools.DBTools.Managers;
using User_Interface.Login_page_mvp.ForgotPasswordPage.View;


namespace OTSC_ui.Pages.Login_page_mvp.Login_page
{
    internal class PresenterLogin
    {
        private readonly ILoginView _loginView;
        private readonly ImodelLogin _imodelka;
        private readonly IRegistrView _registrView;

        internal PresenterLogin(ILoginView loginView, ImodelLogin imodelka, IRegistrView registrView)
        {
            // Model
            _imodelka = imodelka ?? throw new ArgumentNullException(nameof(imodelka));
            

            #region LoginPageConstr
            //login page
            _loginView = loginView ?? throw new ArgumentNullException(nameof(loginView));


            // Exit button
            _loginView.ExitButtonClick += LoginView_ExitButtonClick;
            _loginView.ExitButtonEntered += LoginView_ExitButtonEntered;
            _loginView.ExitButtonLeavd += LoginView_ExitButtonLeavd;


            // Show password button
            _loginView.Show_PswButtonClick += LoginView_Show_PswButtonClick;

            // Login button
            _loginView.LoginButtonClick += LoginView_LoginButtonClick;

            // Resgistr button
            _loginView.RegistrButtonClick += LoginView_RegistrButtonClick;

            // Forgot password
            _loginView.ForgotPassworLinkClick += LoginView_ForgotPassworLinkClick;
            #endregion

            #region RegistrpageConstr
            _registrView = registrView ?? throw new ArgumentNullException(nameof(registrView));


            // Exit button
            _registrView.ExitButtonClick += RegistrView_ExitButtonClick;
            _registrView.ExitButtonEntered += RegistrView_ExitButtonEntered;
            _registrView.ExitButtonLeavd += RegistrView_ExitButtonLeavd;

            // Resgistr button
            _registrView.RegistrButtonClick += RegistrView_RegistrButtonClick;

            //back button
            _registrView.GoBackButtonClick += RegistrView_GoBackButtonClick;

            //email field button
            _registrView.LeaveEmailBoxAndCheckCorrect += RegistrView_LeaveEmailBoxAndCheckCorrect;

            //for all field EXCEPT email
            _registrView.EnterInField += RegistrView_EnterInField;
            _registrView.TextChengedInFieldExceptEmail += RegistrView_TextChengedInFieldExceptEmail;

        #endregion
    }

        






        #region RegistrPage
        // Exit button
        private void RegistrView_ExitButtonClick()
        { 
                Application.Exit();
        }
        private void RegistrView_ExitButtonLeavd()
        {
            _registrView.MakeExitButtonForeBlack();
        }

        private void RegistrView_ExitButtonEntered()
        {
            _registrView.MakeExitButtonForeRed();
        }


        // Resgistr button
        private void RegistrView_RegistrButtonClick(object? sender, (string, string, string) e)
        {
            if (_registrView.CheckForAllFieldsNotEmpty())
            {

               _imodelka.Registr()
            }
        }



        //back button
        private void RegistrView_GoBackButtonClick()
        {
            if (_registrView is Form thisform && _loginView is Form NextForm)
            {
                thisform.Hide();
                NextForm.Show();
            }
        }

        //email field 
        private void RegistrView_LeaveEmailBoxAndCheckCorrect(object? sender, string e)
        {
            if (_registrView.CheckCorrectInputEmail())
            {
                _registrView.MakeNotVisibleEmailerror();
                _registrView.MakeRegistrButtonEnable();
            }
            else
            {
                _registrView.MakeVisibleEmailerror();
            }
        }
        
        
        //for all field EXCEPT email
        private void RegistrView_EnterInField()
        {
            _registrView.MakeRegistrButtonDisable();
        }
        private void RegistrView_TextChengedInFieldExceptEmail()
        {
            if (_registrView.CheckForAllFieldsNotEmpty())
            {
                _registrView.MakeRegistrButtonEnable();
            }
        }
        #endregion

        #region LoginPage

        // Exit button
        private void LoginView_ExitButtonLeavd()
        {
            _loginView.MakeExitButtonForeBlack();
        }

        private void LoginView_ExitButtonEntered()
        {
            _loginView.MakeExitButtonForeRed();
        }

        private void LoginView_ExitButtonClick()
        {
            Application.Exit();
        }

        // Show password button
        private void LoginView_Show_PswButtonClick(object? sender, bool e)
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
        private void LoginView_LoginButtonClick(object? sender, (string, string) e)
        {
            
                (_imodelka.Login, _imodelka.Password) = (long.Parse(e.Item1),e.Item2);
            

            _imodelka.LogInApl();
        }


        // Resgistr button
        private void LoginView_RegistrButtonClick()
        {
            if (_loginView is Form thisform)
            {
                if (_registrView is Form nextform)
                {
                    thisform.Hide();
                    nextform.Show();

                    
                    
                }
            }
        }

        // Forgot password
        private void LoginView_ForgotPassworLinkClick()
        {
            if (_loginView is Form thisform)
            {
                ChangePasswordFormForm changePasswordFormForm = new();
                EmailEnterfrom emailEnterfrom = new();
                ModelForgorPasswordPage modelForgorPasswordPage = new();
                _ = new PresenterForgotPasswoedPage(modelForgorPasswordPage, changePasswordFormForm, emailEnterfrom);
                thisform.Hide();
                emailEnterfrom.ShowDialog();//можно конечно что то делать но бог с ним

                thisform.Show();
            }
        }
        #endregion

    }
        
}
