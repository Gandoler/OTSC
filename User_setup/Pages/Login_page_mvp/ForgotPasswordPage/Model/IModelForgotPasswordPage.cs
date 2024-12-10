namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model
{
    internal interface IModelForgotPasswordPage
    {
        internal bool SendCode(string email);
        internal void MakeNewPasswordQuery(string First, string Second);
        internal bool CheckCode(short Code);



    }
}
