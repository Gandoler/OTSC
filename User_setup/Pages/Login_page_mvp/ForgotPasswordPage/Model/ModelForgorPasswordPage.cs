using OTSC_ui.Tools.DBTools.Managers.ForgotPSW;
using OTSC_ui.Tools.SendMailWithcode.CodeGenerate;
using OTSC_ui.Tools.SendMailWithcode.CodeSend;
namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model
{
    internal class ModelForgorPasswordPage : IModelForgotPasswordPage

    {

        private readonly IEmailService _emailService;
        private readonly IForgotpasswordManager _forgotpasswordManager;
        private readonly ICodeGeneratorMail _codegen;
        private string _code;
        private string _email = string.Empty;

        public string Code { get => _code;}

        public event Action? CodeSendSuccessful;
        public event Action? CodeSendFailedUserdidntExist;
        public event Action? CodeMismatch;
        public event Action? PasswordChangeSuccessfull;
        public event Action? PasswordChangeFailed;
        public event Action? CodeMatch;


        public ModelForgorPasswordPage(IEmailService emailService, IForgotpasswordManager forgotpasswordManager, ICodeGeneratorMail codegen)
        {
            _emailService = emailService;
            _forgotpasswordManager = forgotpasswordManager;
            _codegen = codegen;
            _code = _codegen.GenerateCode();
        }

        public void SendCode(string email)
        {
            if (_forgotpasswordManager.CheckUserExist(email))
            {
                _email= email;
                _emailService.SendEmailAsync(email, "You code", $"{_code}");
                CodeSendSuccessful?.Invoke();
            }
            else
            {
                CodeSendFailedUserdidntExist?.Invoke();
            }
        }

        public void ChangePassword(string password)
        {
            if (_forgotpasswordManager.ChangePassword(password, _email))
            {
                PasswordChangeSuccessfull?.Invoke();
            }
            else
            {
                PasswordChangeFailed?.Invoke();
            }
        }

        void IModelForgotPasswordPage.CheckCode(string code)
        {
            if (code.Equals(_code))
            {
                CodeMatch?.Invoke();
            }
            else
            {
                CodeMismatch?.Invoke();
            }
        }
    }
}
