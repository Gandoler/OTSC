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
            
            Application.Run(new formLogin());
            //Application.Run(new Main_page_Form(ID));

        }
    }
}