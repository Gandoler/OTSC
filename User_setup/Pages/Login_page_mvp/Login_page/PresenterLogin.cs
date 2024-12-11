using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr;
using OTSC_ui.Tools.AppSettingJsonPhars.ConnectionStringManager;
using OTSC_ui.Tools.DBTools.Connection;
using OTSC_ui.Tools.DBTools.Managers.ForgotPSW;
using OTSC_ui.Tools.SendMailWithcode.CodeGenerate;
using OTSC_ui.Tools.SendMailWithcode.CodeSend;
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

            //for all field when leave
            _loginView.LeaveFromFields += _loginView_LeaveFromFields; ;
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


            //for all field when leave
            _registrView.LeaveFromFields += _registrView_LeaveFromFields;
            #endregion


            #region ModelConstruct
            // Model
            _imodelka = imodelka ?? throw new ArgumentNullException(nameof(imodelka));

            // registration
            _imodelka.UserExist += _imodelka_UserExist;
            _imodelka.UserRegistered += _imodelka_UserRegistered;
            _imodelka.UserNotRegistered += _imodelka_UserNotRegistered;

            //login
            _imodelka.LogMismatch += _imodelka_LogMismatch;
            _imodelka.LoginFailed += _imodelka_LoginFailed;
            _imodelka.LoginGo += _imodelka_LoginGo;




            #endregion
        }



        #region model
        // registration
        private void _imodelka_UserNotRegistered(object? sender, string e)
        {
            MessageBox.Show("Unexpected Error", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _imodelka_UserRegistered()
        {
            if (_registrView is Form thisform && _loginView is Form NextForm)
            {
                thisform.Hide();
                NextForm.Show();
            }
        }

        private void _imodelka_UserExist()
        {
            MessageBox.Show("Such User Exist", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //login
        private void _imodelka_LoginGo()
        {//пока вникуда
            MessageBox.Show("ты зашел бро", "Круто", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(_registrView is Form thisform && _loginView is Form Nextform){
                Nextform.Close();
                thisform.Close();
            }

        }

        private void _imodelka_LoginFailed(object? sender, string e)
        {
            MessageBox.Show("Unexpected Error", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _imodelka_LogMismatch()
        {
            MessageBox.Show("Invalid Password Or Login", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion





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
            if (_registrView.CheckPasswordsMatch() &&_registrView.CheckForAllFieldsNotEmpty())
            { (_imodelka.Login, _imodelka.Email, _imodelka.Password) = (long.Parse(e.Item1), e.Item2, e.Item3);

                _imodelka.Registr();
            }
        }



        //back button
        private void RegistrView_GoBackButtonClick()
        {
            if (_registrView is Form thisform && _loginView is Form NextForm)
            {
                thisform.Close();
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




        //for all field when leave
        private void _registrView_LeaveFromFields()
        {
            _registrView.checkEmptyFieldsAndBackPlaceHolder();
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
                // формы
                ChangePasswordFormForm changePasswordFormForm = new();
                EmailEnterfrom emailEnterfrom = new();


                // для бд
                string? connectionString;
                do
                {
                    connectionString = ConnectionStringManager.GetConnectionString();
                } while (connectionString == null);

                ConnectDBManager connectDBManager = new ConnectDBManager(connectionString);

                CodeGeneratorsix codeGenerator = new CodeGeneratorsix();
                EmailServiceWithTemplate emailService = new EmailServiceWithTemplate(ConnectionStringManager.GetEmailSettings());
               //EmailServiceTest emailServiceTest = new EmailServiceTest();
                
                ForgotpasswordManager forgotpasswordManager = new ForgotpasswordManager(connectDBManager);


                //модель
                ModelForgorPasswordPage modelForgorPasswordPage = new(emailService, forgotpasswordManager, codeGenerator);
                _ = new PresenterForgotPasswoedPage(modelForgorPasswordPage, changePasswordFormForm, emailEnterfrom);
                thisform.Hide();
                emailEnterfrom.ShowDialog();//можно конечно что то делать но бог с ним

                thisform.Show();
            }
        }
        //for all field when leave
        private void _loginView_LeaveFromFields()
        {
            _loginView.checkEmptyFieldsAndBackPlaceHolder();
        }



        #endregion

    }
        
}
