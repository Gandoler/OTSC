namespace OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr
{
    internal interface IRegistrView
    {

        // Exit button
        event Action ExitButtonClick;
        event Action ExitButtonEntered;
        event Action ExitButtonLeavd;

        // Resgistr button
        event Action RegistrButtonClick;

        //back button
        event Action GoBackButtonClick;

        //email field button
        event Action EnterEmailTextBox;
        event EventHandler<string> LeaveEmailBoxAndCheckCorrect;


        public void MakeVisibleEmailerror();
        public void MakeNotVisibleEmailerror();

        void MakeExitButtonForeBlack();
        void MakeExitButtonForeRed();

        public bool CheckCorrectInputEmail();

    }
}
