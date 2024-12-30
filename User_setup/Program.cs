using User_Interface.Login_page_mvp.View;
using Serilog;
using OTSC_ui.Pages.Login_page_mvp.Login_page.Model;
using OTSC_ui.Pages.Login_page_mvp.Login_page;
using OTSC_ui.Tools.DBTools.Connection;
using User_Interface.Login_page_mvp.Login.View.Registr;
using OTSC_ui.Tools.DBTools.Managers.Login;
using OTSC_ui.Tools.AppSettingJsonPhars.ConnectionStringManager;
using OTSC_ui.Pages.Login_page_mvp.MustSubsribe;
using OTSC_ui.Pages.Login_page_mvp.Login_page.MustSubsribe;
using OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model;



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


            Log.Information("App start");
            string? connectionString;
            do
            {
                connectionString = ConnectionStringManager.GetConnectionString();
            } while (connectionString == null);

            ConnectDBManager connectDBManager = new ConnectDBManager(connectionString);
            ModelLogin model = new(new LoginManager(connectDBManager));
            LoginFrom loginFrom = new LoginFrom();
            RegistrForm registrForm = new RegistrForm();

            PresenterLogin presenter = new(loginFrom, model, registrForm);

            Application.Run(loginFrom);
            Log.Information("App stop");


            Log.CloseAndFlush();



         
        }
    }
}