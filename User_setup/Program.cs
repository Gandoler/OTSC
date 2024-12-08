using User_Interface.Login_page_mvp.View;
using User_Interface.Login_page_mvp.Login.View.Registr;
using User_Interface.ExtendedTool;
using Serilog;
using Serilog.Sinks.File;

using User_Interface.Login_page_mvp.ForgotPasswordPage.View;
using User_Interface.Login_page_mvp.ForgotPasswordPage;
using OTSC_ui.Pages.Login_page_mvp.Login_page;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
namespace OTSC_ui
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("C:/Users/glkru/OneDrive/Desktop/prj/Project_cpo/User_setup/Properties/logs/myapp.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();



            LoginFrom formLogin = new();
            RegistrForm registrForm = new();
            ModelLogin model = new();

            PresenterLogin presenter = new(formLogin, model,registrForm);
            Log.Information("Приложение запущено.");
            Application.Run(formLogin);



            //EmailEnterfrom emailEnterfrom = new EmailEnterfrom();
            //ChangePasswordFormForm changePasswordFormForm  = new ChangePasswordFormForm();
            //ModelForgorPasswordPage modelForgorPasswordPage = new ModelForgorPasswordPage();
            //PresenterForgotPasswoedPage presenterForgotPasswoedPage = new PresenterForgotPasswoedPage(modelForgorPasswordPage, changePasswordFormForm, emailEnterfrom);
            //Application.Run(emailEnterfrom);
            //Log.CloseAndFlush();

            Log.Information("Приложение закрыто.");
            Log.CloseAndFlush();
            //Application.Run(new CustomShowBox());
        }
    }
}