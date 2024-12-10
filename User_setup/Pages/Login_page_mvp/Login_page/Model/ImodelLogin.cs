namespace OTSC_ui.Pages.Login_page_mvp.Login_page.Model
{
    internal interface ImodelLogin
    {
        long Login { set; }
        string Password { set; }
        string Email{ set;}


        event Action LoginGo;
        event Action LogMismatch;
        event EventHandler<string> LoginFailed;
        event Action UserExist;
        event Action UserRegistered;
        event EventHandler<string> UserNotRegistered;
        internal void LogInApl();
        internal void Registr();

    }
}
