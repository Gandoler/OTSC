using OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model;
using System.Threading.Tasks;

internal static class Program
{
    // Измените метод Main на асинхронный
    static async Task Main()
    {
        MustSubscribeModel mustSubscribeModel = new MustSubscribeModel(new HttpClient());

        // Теперь вызов GetCode будет асинхронным
        await mustSubscribeModel.GetCode(7454368537);
        
    }
}
