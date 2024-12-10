using OTSC_ui.Tools.DBTools.Managers;
using OTSC_ui.Tools.SendMailWithcode.CodeGenerate;
using OTSC_ui.Tools.SendMailWithcode.CodeSend;

namespace OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.Model
{
    internal class ModelForgorPasswordPage : IModelForgotPasswordPage

    {

        private readonly IEmailService _emailService;
        private readonly ILoginManager _loginManager;
        private readonly ICodeGeneratorMail _codegen;
        private string _code;

        public string Code { get => _code;}

        public event Action? CodeSendSuccessful;
        public event Action? CodeSendFailed;
        public event Action? CodeMismatch;
        public event Action? PasswordChangeSuccessfull;
        public event Action? PasswordChangeFailed;


        public ModelForgorPasswordPage(IEmailService emailService, ILoginManager loginManager, ICodeGeneratorMail codegen)
        {
            _emailService = emailService;
            _loginManager = loginManager;
            _codegen = codegen;
            _code = _codegen.GenerateCode();
        }

        public void SendCode(string email)
        {
            _emailService.
        }

        public void ChangePassword(string First, string Second)
        {
            throw new NotImplementedException();
        }
    }
}
