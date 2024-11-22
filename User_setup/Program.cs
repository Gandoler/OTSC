using User_Interface.Login_page_mvp.View;
using User_Interface.Login_page_mvp.Login.View.Registr;
using User_Interface.ExtendedTool;
using User_Interface.Login_page_mvp.Login_page.Model;
using User_Interface.Login_page_mvp.Login_page;
namespace User_setup
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {




            formLogin formLogin = new formLogin();
            ModelLogin model = new ModelLogin();

            PresenterLogin presenter = new PresenterLogin(formLogin, model);
            Application.Run(formLogin);



            //Application.Run(new CustomShowBox());
        }
    }
}