using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.ForgotPasswordPage.Model;
using User_Interface.Login_page_mvp.ForgotPasswordPage.View;
using User_Interface.Login_page_mvp.Login_page.View;
using User_setup;

namespace User_Interface.Login_page_mvp.ForgotPassword
{
    internal class PresenterForgotPasswoedPage
    {
        private readonly IModelForgotPasswordPage _modelForgotPasswordPage;
        private readonly IViewForgotPasswordPage _viewForgotPasswordPage;


        public PresenterForgotPasswoedPage(IModelForgotPasswordPage modelForgotPasswordPage, IViewForgotPasswordPage viewForgotPasswordPage)
        {
            _modelForgotPasswordPage  = modelForgotPasswordPage ?? throw new ArgumentNullException(nameof(IModelForgotPasswordPage));
            _viewForgotPasswordPage = viewForgotPasswordPage ?? throw new ArgumentNullException(nameof(IViewForgotPasswordPage));
            //podpichiki dlia vida
            //
            //
            //
            // dlia vihoda
            _viewForgotPasswordPage.ExitButtonPress += _viewForgotPasswordPage_ExitButtonPress;
            //moment kogda vvel email doljno razblokirovat pole vvoda koda
            _viewForgotPasswordPage.EnterEmailOpenCodeField += _viewForgotPasswordPage_SendCodeButtonPress;
            // dlia momenta kogda kod uzje vveden 
            // doljno dernut na polia zameni parolia
            _viewForgotPasswordPage.SaveNewPasswordButtonPress += _viewForgotPasswordPage_SaveNewPasswordButtonPress;
            //esli tip reshit pomeniat pochtu
            _viewForgotPasswordPage.EnterInEmailField += _viewForgotPasswordPage_EnterInEmailField;
            //tut tip poterial nad soboi kontrol i vvel vtoroi parol ne verno
            _viewForgotPasswordPage.EnterInPasswordBox += _viewForgotPasswordPage_EnterInPasswordBox;
            // tut sootvetsvenno moment kogda on vvel kod
            _viewForgotPasswordPage.EnterEmailOpenCodeField += _viewForgotPasswordPage_EnterEmailOpenCodeField;


        }

        private void _viewForgotPasswordPage_EnterEmailOpenCodeField(object? sender, EventArgs e)
        {
            
        }

        private void _viewForgotPasswordPage_EnterInPasswordBox()
        {
            _viewForgotPasswordPage.DisableMissmatchLabel();
        }

        private void _viewForgotPasswordPage_EnterInEmailField()
        {
            _viewForgotPasswordPage.MakeCodeFieldDisable();
        }

        private void _viewForgotPasswordPage_SaveNewPasswordButtonPress(object? sender, EventArgs e)
        {
            string first = _viewForgotPasswordPage.PasswordField;
            string second = _viewForgotPasswordPage.PasswordSecondField;
            if (_modelForgotPasswordPage.isSecEqualFirst(first, second))
            {

            }
            else
            {
                _viewForgotPasswordPage.ClearPasswords();
            }
        }

        private void _viewForgotPasswordPage_SendCodeButtonPress(object? sender, EventArgs e)
        {
            _viewForgotPasswordPage.MakeCodeFieldEnable();

        }

        private void _viewForgotPasswordPage_ExitButtonPress(object? sender, EventArgs e)
        {
            ExitSaftyClass.AplicationExitSafety();

        }
    }
}
