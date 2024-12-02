using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.Login_page_mvp.ForgotPasswordPage.Model;
using User_Interface.Login_page_mvp.ForgotPasswordPage.View;
using User_Interface.Login_page_mvp.Login_page;
using User_Interface.Login_page_mvp.Login_page.Model;
using User_Interface.Login_page_mvp.Login_page.View;
using User_Interface.Login_page_mvp.View;
using User_setup;

namespace User_Interface.Login_page_mvp.ForgotPassword
{
    internal class PresenterForgotPasswoedPage
    {
        private readonly IModelForgotPasswordPage _modelForgotPasswordPage;
        private readonly IViewChangePasswod _viewForgotPasswordPage;
        private readonly IViewEmailEnter _viewEmailEnter;


        public PresenterForgotPasswoedPage(IModelForgotPasswordPage modelForgotPasswordPage, IViewChangePasswod viewForgotPasswordPage, IViewEmailEnter viewEmailEnter)
        {
            _modelForgotPasswordPage= modelForgotPasswordPage;
            _viewForgotPasswordPage = viewForgotPasswordPage;

            //for email enter page
            _viewEmailEnter = viewEmailEnter;
            //exit button
            _viewEmailEnter.EnterExitButton += _viewEmailEnter_EnterExitButton;
            _viewEmailEnter.LeaveExitButton += _viewEmailEnter_LeaveExitButton;
            _viewEmailEnter.ExitForgotPageButtonClick += _viewEmailEnter_ExitForgotPageButtonClick;
            //leave feom email textbox
            _viewEmailEnter.LeaveEmailBoxAndCheckCorrect += _viewEmailEnter_LeaveEmailBoxAndCheckCorrect;
            //press sendcodebutton
            _viewEmailEnter.SendCodeButtonClick += _viewEmailEnter_SendCodeButtonClick;


        }




        #region emailpage
        private void _viewEmailEnter_SendCodeButtonClick()
        {
            throw new NotImplementedException();
        }
        private void _viewEmailEnter_LeaveEmailBoxAndCheckCorrect(object? sender, string e)
        {
            throw new NotImplementedException();
        }
        private void _viewEmailEnter_ExitForgotPageButtonClick(object? sender, EventArgs e)
        {
            


        }
        private void _viewEmailEnter_LeaveExitButton(object? sender, Color e)
        {
            e = Color.Black;
        }
        
        private void _viewEmailEnter_EnterExitButton(object? sender, Color e)
        {
           e= Color.Red;
        }
        #endregion
        
    }
}
