using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using User_Interface.Main_page;

namespace User_setup
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string relativePath = "Data/Data_config_for_app.json"; // ������������� ����
            string absolutePath = Path.GetFullPath(relativePath); // ����������� � ���������� ����

       
            ApplicationConfiguration.Initialize();
            long ID = 314627387;//������

            Application.Run(new Login_page());
           
        }
    }
}