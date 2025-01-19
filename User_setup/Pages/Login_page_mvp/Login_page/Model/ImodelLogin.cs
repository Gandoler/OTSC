namespace OTSC_ui.Pages.Login_page_mvp.Login_page.Model
{
    internal interface ImodelLogin
    {
        long Login { set; }
        string Password { set; }
        string Email{ set;}

        //login
        event Action LoginGo;
        event Action LogMismatch;
        event EventHandler<string> LoginFailed;
        
        //registr
        event Action UserRegistered;
        event EventHandler<string> UserNotRegistered;


        //check user existance
        event Action UserExist;
        event Action UserDidntExist;

        public void CheckUserDidntExist();
        internal void LogInApl();
        internal void Registr();

    }
}
