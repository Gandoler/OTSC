namespace OTSC_ui.Pages.Login_page_mvp.Login_page.Model
{
    internal interface ImodelLogin
    {
        string Login { set; }
        string Password { set; }



        event Action LoginGo;
        event Action LogMismatch;
        event Action LoginFailed;
        event Action UserExist;
        event Action UserRegistered;
        event Action UserNotRegistered;
        internal void LogInApl();
        internal void Registr();

    }
}
