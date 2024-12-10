using User_Interface.Login_page_mvp.View;
using User_Interface.Login_page_mvp.Login.View.Registr;
using User_Interface.ExtendedTool;
using Serilog;
using Serilog.Sinks.File;

using User_Interface.Login_page_mvp.ForgotPasswordPage.View;
using User_Interface.Login_page_mvp.ForgotPasswordPage;
using OTSC_ui.Pages.Login_page_mvp.Login_page;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
using OTSC_ui.Tools.DBTools.Connection;
using Newtonsoft.Json;
using OTSC_ui.Tools.AppSettingJsonPhars.Reader;
using OTSC_ui.Tools.ConnectionStringManager;
using OTSC_ui.Tools.DBTools.Managers;
namespace OTSC_ui
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // логер
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("C:/Users/glkru/OneDrive/Desktop/prj/Project_cpo/User_setup/Properties/logs/myapp.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Приложение запущено.");

            //строка подключения к дб
            string? connectionString;
            do
            {
                connectionString = ConnectionStringManager.GetConnectionString();
            } while (connectionString == null);
            // менеджер подключения к дб
           
                ConnectDBManager connectDBManager = new ConnectDBManager(connectionString);
            
            
            //в модель передаем логин менеджер

            ModelLogin model = new(new LoginManager(connectDBManager));
            LoginFrom loginFrom = new LoginFrom();
            RegistrForm registrForm = new RegistrForm();

            PresenterLogin presenter = new(loginFrom, model, registrForm);
            Application.Run(loginFrom);




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