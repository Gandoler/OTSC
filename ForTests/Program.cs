using OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model;
using OTSC_ui.Tools.HTTPqUERY;
using System.Threading.Tasks;

internal static class Program
{
    // Измените метод Main на асинхронный
    static async Task Main()
    {
        MustSubscribeModel mustSubscribeModel = new MustSubscribeModel(new HttpQuerysPost(new HttpClient()," http://localhost:5291"));
        for (int i = 0; i < 230; i++)
        {
            // Теперь вызов GetCode будет асинхронным
            await mustSubscribeModel.GetCode(7454368537);
        }
    }
}
