using Serilog.Core;

namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model
{
    internal interface IModelForgotPasswordPage
    {
        public string Code { get; }
        internal void SendCode(string email);
        internal void CheckCode(string code);
        internal void ChangePassword(string Password);

        //code send 
        event Action CodeSendSuccessful;
        event Action CodeSendFailedUserdidntExist;
        
        // code check
        event Action CodeMismatch;
        event Action CodeMatch;

        // Password change
        event Action PasswordChangeSuccessfull;
        event Action PasswordChangeFailed;

    }
}
