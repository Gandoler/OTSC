namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    public class EmailSettings : Itemplates
    {
        public string? SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string? SenderEmail { get; set; }
        public string? SenderPassword { get; set; }
    }
}
