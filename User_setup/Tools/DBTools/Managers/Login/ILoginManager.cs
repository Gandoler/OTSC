namespace OTSC_ui.Tools.DBTools.Managers.Login
{
    internal interface ILoginManager
    {
        public bool Login(long login, string passwoerd);
        public bool Registr(long login, string email, string password);
        public bool CheckUserDidntExist(long login, string email);
        public void Dispose();
    }
}
