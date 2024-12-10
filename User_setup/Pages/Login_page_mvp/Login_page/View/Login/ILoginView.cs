namespace OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login
{
    internal interface ILoginView
    {
     
        // Exit button
        event Action ExitButtonClick;
        event Action ExitButtonEntered;
        event Action ExitButtonLeavd;

        // Show password button
        event EventHandler<bool> Show_PswButtonClick;
        
        // Login button
        event EventHandler<(string, string)> LoginButtonClick;

        // Resgistr button
        event Action RegistrButtonClick;

        // Forgot password
        event Action ForgotPassworLinkClick;

       //for all field leave
        event Action LeaveFromFields;
        void ShowPsw();
        void HidePsw();

        void MakeExitButtonForeBlack();
        void MakeExitButtonForeRed();

        public void checkEmptyFieldsAndBackPlaceHolder();

    }
}