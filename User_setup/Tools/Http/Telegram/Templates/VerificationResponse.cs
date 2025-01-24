namespace OTSC_ui.Tools.Http.Telegram.Templates
{
    public class VerificationResponse
    {
        public string Message { get; set; } = string.Empty;
        public int Code { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
