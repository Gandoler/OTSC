using User_Interface.Login_page_mvp.Login.Model;
using User_Interface.Login_page_mvp.Login.Presenter;
using User_Interface.Login_page_mvp.View;

namespace User_setup
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
           

       
            ApplicationConfiguration.Initialize();
            long ID = 314627387;//менять
            //SSSS
            formLogin formLogin = new formLogin();
            Model model = new Model();
            Presenter presenter = new Presenter(formLogin, model);
            Application.Run(formLogin);
            //Application.Run(new Main_page_Form(ID));

        }
    }
}