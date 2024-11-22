using User_Interface.Login_page_mvp.View;
using User_Interface.Login_page_mvp.Login.View.Registr;
using User_Interface.ExtendedTool;
using User_Interface.Login_page_mvp.Login_page.Model;
using User_Interface.Login_page_mvp.Login_page;
using Serilog;
using Serilog.Sinks.File;
namespace User_setup
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("C:/Users/glkru/OneDrive/Desktop/prj/Project_cpo/User_setup/Properties/logs/myapp.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();



            formLogin formLogin = new formLogin();
            ModelLogin model = new ModelLogin();

            PresenterLogin presenter = new PresenterLogin(formLogin, model);
            Log.Information("Приложение запущено.");
            Application.Run(formLogin);





            Log.CloseAndFlush();
            //Application.Run(new CustomShowBox());
        }
    }
}