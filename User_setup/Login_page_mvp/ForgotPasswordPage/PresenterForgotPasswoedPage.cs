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
        private readonly IViewChangePasswod _viewForgotPasswordPage;
        private readonly IViewEmailEnter _viewEmailEnter;


        public PresenterForgotPasswoedPage(IModelForgotPasswordPage modelForgotPasswordPage, IViewChangePasswod viewForgotPasswordPage, IViewEmailEnter viewEmailEnter)
        {
            _modelForgotPasswordPage= modelForgotPasswordPage;
            _viewForgotPasswordPage = viewForgotPasswordPage;
            _viewEmailEnter= viewEmailEnter;



        }

     
    }
}
