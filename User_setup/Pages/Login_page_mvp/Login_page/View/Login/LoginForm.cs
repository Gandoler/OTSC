using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login;
using User_Interface.Login_page_mvp.Login.View.Registr;

namespace User_Interface.Login_page_mvp.View
{
    internal partial class LoginFrom : Form, ILoginView
    {
        public LoginFrom()
        {
            InitializeComponent();
           
        }

        public event Action ExitButtonClick;
        public event EventHandler<bool> Show_PswButtonClick;
        public event EventHandler<(string, string)> LoginButtonClick;
        public event Action RegistrButtonClick;
        public event Action ForgotPassworLinkClick;

        public void HidePsw()
        {
            throw new NotImplementedException();
        }

        public void ShowPsw()
        {
            throw new NotImplementedException();
        }
    }
}
