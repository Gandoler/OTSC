using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Login;
using User_Interface.Login_page_mvp.Login.View.Registr;

namespace User_Interface.Login_page_mvp.View
{
    internal partial class LoginFrom : Form, ILoginView
    {
        public LoginFrom()
        {
            InitializeComponent();
            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();
            // Show password button
            ShowPswCheckBox.Click += (s, e) => Show_PswButtonClick?.Invoke(this, ShowPswCheckBox.Checked);
            // Login button
            LoginButton.Click += (s, e) => LoginButtonClick?.Invoke(this, (LogintextBox.Text, PasswordTextBox.Text));
            // Resgistr button
            RegistrButton.Click += (s, e) => RegistrButtonClick?.Invoke();
            // Forgot password link
            ForgotPasswordLink.Click += (s, e) => ForgotPassworLinkClick?.Invoke();
        }

        // Exit button
        public event Action ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;

        // Show password button
        public event EventHandler<bool>? Show_PswButtonClick;

        // Login button
        public event EventHandler<(string, string)>? LoginButtonClick;

        // Resgistr button
        public event Action? RegistrButtonClick;

        // Forgot password link
        public event Action? ForgotPassworLinkClick;

        public void HidePsw()
        {
            PasswordTextBox.PasswordChar = '*';
        }

        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

        public void ShowPsw()
        {
            PasswordTextBox.PasswordChar = '\0';
        }
    }
}
