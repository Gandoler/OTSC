using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Serilog;

using OTSC_ui.Login_page_mvp.ForgotPasswordPage.View.ChangePassword;
using OTSC_ui.Login_page_mvp.ForgotPasswordPage.View.SendCode;
using User_Interface.Login_page_mvp.ForgotPasswordPage.Model;
using User_Interface.Login_page_mvp.Login_page;
using User_Interface.Login_page_mvp.Login_page.Model;
using User_Interface.Login_page_mvp.Login_page.View;
using User_Interface.Login_page_mvp.View;
using User_setup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace User_Interface.Login_page_mvp.ForgotPassword
{
    internal class PresenterForgotPasswoedPage
    {
        private readonly IModelForgotPasswordPage _modelForgotPasswordPage;
        private readonly IViewChangePasswod _viewNewPasswordPage;
        private readonly IViewEmailEnter _viewEmailEnter;
        private bool DidPasswordChange = false;

        public PresenterForgotPasswoedPage(IModelForgotPasswordPage modelForgotPasswordPage, IViewChangePasswod viewForgotPasswordPage, IViewEmailEnter viewEmailEnter)
        {
            _modelForgotPasswordPage= modelForgotPasswordPage;

            #region emailEnterPageListeners
            //for email enter page
            _viewEmailEnter = viewEmailEnter;
            //exit button
            _viewEmailEnter.EnterExitButton += _viewEmailEnter_EnterExitButton;
            _viewEmailEnter.LeaveExitButton += _viewEmailEnter_LeaveExitButton;
            _viewEmailEnter.ExitForgotPageButtonClick += _viewEmailEnter_ExitForgotPageButtonClick;
            //leave and enter feom email textbox
            _viewEmailEnter.LeaveEmailBoxAndCheckCorrect += _viewEmailEnter_LeaveEmailBoxAndCheckCorrect;
            _viewEmailEnter.EnterEmailTextBox += _viewEmailEnter_EnterEmailTextBox;
            //press sendcodebutton
            _viewEmailEnter.SendCodeButtonClick += _viewEmailEnter_SendCodeButtonClick;
            #endregion


            #region NewPasswrdListen
            //init
            _viewNewPasswordPage = viewForgotPasswordPage;


            //exit button
            _viewNewPasswordPage.ExitButtonEntered += _viewNewPasswordPage_ExitButtonEntered;
            _viewNewPasswordPage.ExitButtonLeavd += _viewNewPasswordPage_ExitButtonLeavd;
            _viewNewPasswordPage.ExitForgotpageButtonClick += _viewNewPasswordPage_ExitForgotpageButtonClick;


            // save new password button
            _viewNewPasswordPage.Save_New_Password_buttonClick += _viewNewPasswordPage_Save_New_Password_buttonClick;

            //code Field
            _viewNewPasswordPage.LeaveCodeField += _viewNewPasswordPage_LeaveCodeField;

            //PasswordsFields
            _viewNewPasswordPage.EnterInPassswordsFields += _viewNewPasswordPage_EnterInPassswordsFields;
                
            //back button
            _viewNewPasswordPage.GoBackButtonCLick += _viewNewPasswordPage_GoBackButtonCLick;
            #endregion
        }





        #region emailpage
        //press sendcodebutton
        private void _viewEmailEnter_SendCodeButtonClick()
        {
            if (_viewEmailEnter.CheckCorrectInputEmail())
            {
                Form? thisForm = _viewEmailEnter as Form;
                Form? nextForm = _viewNewPasswordPage as Form;
                if (thisForm != null && nextForm != null)
                {

                    thisForm.Hide();//тут мы прячем форму для ввода имейла
                    DialogResult response = nextForm.ShowDialog();// тут как диалог открываем окно для нового пароля как диалог
                    if (response == DialogResult.TryAgain)// это будет если кнопку назад нажать
                    {
                        thisForm.Show();
                    }
                    else// это будет если кнопку закрытия нажать
                    {
                        thisForm.DialogResult = DialogResult.Cancel;
                        thisForm.Close();
                    }

                }
            }
            else
            {
                Log.Information("input incorrect email");
                _viewEmailEnter.MakeSendButtonDisable();
                _viewEmailEnter.MakeVisibleEmailerror();
            }

        }
        //leave and enter feom email textbox
        private void _viewEmailEnter_LeaveEmailBoxAndCheckCorrect(object? sender, string email_string)
        {
            
            if (_viewEmailEnter.CheckCorrectInputEmail())
            {
                Log.Information("email correct");
                /////////////////////////////////////
                ////////////////////////////////////////
                //////////////////////////////////////// Model performance
                /////////////////////////////////////
                if (/*tut*/true)
                {
                    _viewEmailEnter.MakeSendButtonEnable();
                    _viewEmailEnter.MakeNotVisibleEmailerror();
                }
            }
            else
            {
                Log.Information("input incorrect email");
                _viewEmailEnter.MakeSendButtonDisable();
                _viewEmailEnter.MakeVisibleEmailerror();
            }
        }
        private void _viewEmailEnter_EnterEmailTextBox()
        {
            _viewEmailEnter.MakeSendButtonDisable();
           _viewEmailEnter.MakeNotVisibleEmailerror();
        }
        
        //exit button
        private void _viewEmailEnter_ExitForgotPageButtonClick()
        {
            var thisForm = _viewEmailEnter as Form;
            if (thisForm != null)
            {
                thisForm.DialogResult = DialogResult.Cancel;
                thisForm.Close();
            }
        }
        private void _viewEmailEnter_LeaveExitButton()
        {
            _viewEmailEnter.MakeCloseButtonBlack();
        }
        
        private void _viewEmailEnter_EnterExitButton()
        {
            _viewEmailEnter.MakeCloseButtonRed();
        }
        #endregion


        #region sendCodePage


        //exit button

        private void _viewNewPasswordPage_ExitForgotpageButtonClick()
        {
            Form? thisForm = _viewNewPasswordPage as Form;
            if (thisForm != null)
            {
                thisForm.DialogResult = DialogResult.Cancel;
                thisForm.Close();
            }
        }

        private void _viewNewPasswordPage_ExitButtonLeavd(object? sender, Color e)
        {
            _viewNewPasswordPage.MakeCloseButtonBlack();
        }

        private void _viewNewPasswordPage_ExitButtonEntered(object? sender, Color e)
        {
            _viewNewPasswordPage.MakeCloseButtonRed();
        }

        // save new password button

        private void _viewNewPasswordPage_Save_New_Password_buttonClick(object? sender, (string, string) e)
        {
            if(e.Item1==e.Item2)
            { 
                try
                {
                    /////////////////////////////////////
                    ////////////////////////////////////////
                    //////////////////////////////////////// Model performance
                    /////////////////////////////////////
                    DidPasswordChange = true;
                    
                    
                }
                catch(Exception ex) 
                {
                    Log.Error(ex.Message, "Ошибка в {MethodName} Class {ClassName}", 
                        nameof(_viewNewPasswordPage_Save_New_Password_buttonClick), nameof(PresenterForgotPasswoedPage));
                    MessageBox.Show("Произошла ошибка!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _viewNewPasswordPage.ClearPasswords();
                _viewNewPasswordPage.MakeVisibleErrorLable();
            }
        }

        //code Field
        private void _viewNewPasswordPage_LeaveCodeField(object? sender, string e)
        {
            short code = 0;
            if (short.TryParse(e,out code))
            {


                /////////////////////////////////////
                ////////////////////////////////////////
                //////////////////////////////////////// Model performance
                /////////////////////////////////////
                if (/*model*/true)
                {
                    _viewNewPasswordPage.EnablepasswordSField();


                }
                else
                {
                    _viewNewPasswordPage.DisablepasswordSField();
                }
            }
        }

        //PasswordsFields
        private void _viewNewPasswordPage_EnterInPassswordsFields()
        {
            _viewNewPasswordPage.MakeNotVisibleErrorLable();
        }

        //back button
        private void _viewNewPasswordPage_GoBackButtonCLick()
        {
            Form? thisForm = _viewNewPasswordPage as Form;
            if (thisForm != null)
            {
                thisForm.DialogResult = DialogResult.TryAgain;
                thisForm.Close();
            }
        }
        #endregion
    }
}
