namespace OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr
{
    internal interface IRegistrView
    {
        //for all field EXCEPT email
        event Action EnterInField;
        event Action TextChengedInFieldExceptEmail;


        // Exit button
        event Action ExitButtonClick;
        event Action ExitButtonEntered;
        event Action ExitButtonLeavd;

        // Resgistr button
        event EventHandler<(string,string,string)> RegistrButtonClick;

        //back button
        event Action GoBackButtonClick;

        //email field button
        
        event EventHandler<string> LeaveEmailBoxAndCheckCorrect;


        public void MakeVisibleEmailerror();
        public void MakeNotVisibleEmailerror();

        public void MakeExitButtonForeBlack();
        public void MakeExitButtonForeRed();

        public bool CheckCorrectInputEmail();

        public bool CheckForAllFieldsNotEmpty();

        public void MakeRegistrButtonEnable();
        public void MakeRegistrButtonDisable();




    }
}
