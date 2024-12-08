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

            
           

            //login page
            _loginView = loginView ?? throw new ArgumentNullException(nameof(loginView));
            
        }

        #region LoginPage
        
        #endregion
        

    }
}
