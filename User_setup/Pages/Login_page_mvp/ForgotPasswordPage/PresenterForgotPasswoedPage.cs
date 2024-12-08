using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Serilog;
using User_Interface.Login_page_mvp.Login_page;
using User_Interface.Login_page_mvp.Login_page.Model;
using User_Interface.Login_page_mvp.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.ChangePassword;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.SendCode;

namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage
{
    internal class PresenterForgotPasswoedPage
    {
        private readonly IModelForgotPasswordPage _modelForgotPasswordPage;
        private readonly IViewChangePasswod _viewNewPasswordPage;
        private readonly IViewEmailEnter _viewEmailEnter;

        public PresenterForgotPasswoedPage(IModelForgotPasswordPage modelForgotPasswordPage, IViewChangePasswod viewForgotPasswordPage, IViewEmailEnter viewEmailEnter)
        {
            _modelForgotPasswordPage = modelForgotPasswordPage;

            #region emailEnterPageListeners
            //for email enter page
            _viewEmailEnter = viewEmailEnter;
            //exit button
            _viewEmailEnter.EnterExitButton += ViewEmailEnter_EnterExitButton;
            _viewEmailEnter.LeaveExitButton += ViewEmailEnter_LeaveExitButton;
            _viewEmailEnter.ExitForgotPageButtonClick += ViewEmailEnter_ExitForgotPageButtonClick;
            //leave and enter feom email textbox
            _viewEmailEnter.LeaveEmailBoxAndCheckCorrect += ViewEmailEnter_LeaveEmailBoxAndCheckCorrect;
            _viewEmailEnter.EnterEmailTextBox += ViewEmailEnter_EnterEmailTextBox;
            //press sendcodebutton
            _viewEmailEnter.SendCodeButtonClick += ViewEmailEnter_SendCodeButtonClick;
            #endregion


            #region NewPasswrdListen
            //init
            _viewNewPasswordPage = viewForgotPasswordPage;


            //exit button
            _viewNewPasswordPage.ExitButtonEntered += ViewNewPasswordPage_ExitButtonEntered;
            _viewNewPasswordPage.ExitButtonLeavd += ViewNewPasswordPage_ExitButtonLeavd;
            _viewNewPasswordPage.ExitForgotpageButtonClick += ViewNewPasswordPage_ExitForgotpageButtonClick;


            // save new password button
            _viewNewPasswordPage.Save_New_Password_buttonClick += ViewNewPasswordPage_Save_New_Password_buttonClick;

            //code Field
            _viewNewPasswordPage.LeaveCodeField += ViewNewPasswordPage_LeaveCodeField;

            //PasswordsFields
            _viewNewPasswordPage.EnterInPassswordsFields += ViewNewPasswordPage_EnterInPassswordsFields;

            //back button
            _viewNewPasswordPage.GoBackButtonCLick += ViewNewPasswordPage_GoBackButtonCLick;
            #endregion
        }





        #region emailpage
        //press sendcodebutton
        private void ViewEmailEnter_SendCodeButtonClick()
        {
            if (_viewEmailEnter.CheckCorrectInputEmail())
            {
                if (_viewEmailEnter is Form thisForm && _viewNewPasswordPage is Form nextForm)
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
        private void ViewEmailEnter_LeaveEmailBoxAndCheckCorrect(object? sender, string email_string)
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
        private void ViewEmailEnter_EnterEmailTextBox()
        {
            _viewEmailEnter.MakeSendButtonDisable();
            _viewEmailEnter.MakeNotVisibleEmailerror();
        }

        //exit button
        private void ViewEmailEnter_ExitForgotPageButtonClick()
        {
            if (_viewEmailEnter is Form thisForm)
            {
                thisForm.DialogResult = DialogResult.Cancel;
                thisForm.Close();
            }
        }
        private void ViewEmailEnter_LeaveExitButton()
        {
            _viewEmailEnter.MakeCloseButtonBlack();
        }

        private void ViewEmailEnter_EnterExitButton()
        {
            _viewEmailEnter.MakeCloseButtonRed();
        }
        #endregion


        #region sendCodePage


        //exit button

        private void ViewNewPasswordPage_ExitForgotpageButtonClick()
        {
            if (_viewNewPasswordPage is Form thisForm)
            {
                thisForm.DialogResult = DialogResult.Cancel;
                thisForm.Close();
            }
        }

        private void ViewNewPasswordPage_ExitButtonLeavd()
        {
            _viewNewPasswordPage.MakeCloseButtonBlack();
        }

        private void ViewNewPasswordPage_ExitButtonEntered()
        {
            _viewNewPasswordPage.MakeCloseButtonRed();
        }

        // save new password button

        private void ViewNewPasswordPage_Save_New_Password_buttonClick(object? sender, (string, string) e)
        {
            if (e.Item1 == e.Item2 && e.Item1 != "")
            {
                try
                {
                    /////////////////////////////////////
                    ////////////////////////////////////////
                    //////////////////////////////////////// Model performance
                    /////////////////////////////////////


                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message, "Ошибка в {MethodName} Class {ClassName}",
                        nameof(ViewNewPasswordPage_Save_New_Password_buttonClick), nameof(PresenterForgotPasswoedPage));
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
        private void ViewNewPasswordPage_LeaveCodeField(object? sender, string e)
        {
            if (e != null && e != "")
            {
                if (int.TryParse(e, result: out int code))
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
        }

        //PasswordsFields
        private void ViewNewPasswordPage_EnterInPassswordsFields()
        {
            _viewNewPasswordPage.MakeNotVisibleErrorLable();
        }

        //back button
        private void ViewNewPasswordPage_GoBackButtonCLick()
        {
            if (_viewNewPasswordPage is Form thisForm)
            {
                thisForm.DialogResult = DialogResult.TryAgain;
                thisForm.Close();
            }
        }
        #endregion
    }
}
