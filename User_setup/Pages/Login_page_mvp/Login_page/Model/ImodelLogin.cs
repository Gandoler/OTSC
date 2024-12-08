namespace OTSC_ui.Pages.Login_page_mvp.Login_page.Model
{
    internal interface ImodelLogin
    {
        string Login { set; }
        string Password { set; }


        internal void LogInApl();

        event Action LoginGo;
        event Action LogMismatch;
        event Action UserExist;
        event Action UserRegistered;

    }
}
