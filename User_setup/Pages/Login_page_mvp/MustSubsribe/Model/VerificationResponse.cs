namespace OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model
{
    public class VerificationResponse
    {
        public string Message { get; set; } = string.Empty;
        public int Code { get; set; } 
        public bool IsSubscribed { get; set; }
    }
}
