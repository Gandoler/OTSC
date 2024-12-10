namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.SendCode
{
    internal interface IViewEmailEnter
    {
        // Exit button
        event Action EnterExitButton;
        event Action LeaveExitButton;
        event Action ExitForgotPageButtonClick;

        // Email field
        event Action EnterEmailTextBox;
        event EventHandler<string> LeaveEmailBoxAndCheckCorrect;

        // SendCode Button
        event Action SendCodeButtonClick;



        public void MakeVisibleEmailerror();
        public void MakeNotVisibleEmailerror();
        public void MakeSendButtonEnable();
        public void MakeSendButtonDisable();

        public void MakeCloseButtonRed();
        public void MakeCloseButtonBlack();

        public bool CheckCorrectInputEmail();
    }
}
