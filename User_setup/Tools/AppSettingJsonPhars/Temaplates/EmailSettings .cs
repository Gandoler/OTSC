using Serilog;

namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    public class EmailSettings : Itemplates
    {
        public string? SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string? SenderEmail { get; set; }
        public string? SenderPassword { get; set; }

   
        public string GetConnectionString()
        {
            if (string.IsNullOrWhiteSpace(SmtpServer) ||
                SmtpPort <= 0 ||
                string.IsNullOrWhiteSpace(SenderEmail) ||
                string.IsNullOrWhiteSpace(SenderPassword))
            {
                Log.Error("EmailSettings:One or more required fields are missing for the SMTP connection string.");
                
            }

            return $"smtp://{SmtpServer}:{SmtpPort};Username={SenderEmail};Password={SenderPassword};";
        }
        public override string ToString()
        {
            return $"SmtpServer: {SmtpServer}, SmtpPort: {SmtpPort}, SenderEmail: {SenderEmail}, SenderPassword: {SenderPassword}";
        }
    }
}
