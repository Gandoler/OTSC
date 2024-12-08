namespace OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login
{
    internal interface ILoginView
    {
     
        // Exit button
        event Action ExitButtonClick;
        
        // Show password button
        event EventHandler<bool> Show_PswButtonClick;
        
        // Login button
        event EventHandler<(string, string)> LoginButtonClick;

        // Resgistr button
        event Action RegistrButtonClick;

        // Forgot password
        event Action ForgotPassworLinkClick;

        //
        void ShowPsw();
        void HidePsw();
        



    }
}