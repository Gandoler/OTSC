using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.ForgotPasswordPage.Model;
using User_Interface.Login_page_mvp.ForgotPasswordPage.View;
using User_Interface.Login_page_mvp.Login_page.View;

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
            _viewForgotPasswordPage.ExitButtonPress += _viewForgotPasswordPage_ExitButtonPress;
            _viewForgotPasswordPage.SendCodeButtonPress += _viewForgotPasswordPage_SendCodeButtonPress;
            _viewForgotPasswordPage.SaveNewPasswordButtonPress += _viewForgotPasswordPage_SaveNewPasswordButtonPress;
            _viewForgotPasswordPage.EnterInEmailField += _viewForgotPasswordPage_EnterInEmailField;
            
            
        }

        private void _viewForgotPasswordPage_EnterInEmailField()
        {
            _viewForgotPasswordPage.MakeCodeFieldDisable();
        }

        private void _viewForgotPasswordPage_SaveNewPasswordButtonPress(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _viewForgotPasswordPage_SendCodeButtonPress(object? sender, EventArgs e)
        {
            _viewForgotPasswordPage.MakeCodeFieldEnable();
        }

        private void _viewForgotPasswordPage_ExitButtonPress(object? sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
