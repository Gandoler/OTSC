

namespace User_setup
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
           

       
            ApplicationConfiguration.Initialize();
            long ID = 314627387;//������

            Application.Run(new Main_page(314627387));
           
        }
    }
}