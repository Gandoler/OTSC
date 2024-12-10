using Serilog.Core;

namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model
{
    internal interface IModelForgotPasswordPage
    {
        public string Code { get; }
        internal void SendCode(string email);
        internal void ChangePassword(string First, string Second);

        //code send 
        event Action CodeSendSuccessful;
        event Action CodeSendFailed;
        
        // code check
        event Action CodeMismatch;

        // Password change
        event Action PasswordChangeSuccessfull;
        event Action PasswordChangeFailed;

    }
}
