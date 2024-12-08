using OTSC_ui.Pages.Login_page_mvp.Login_page.View.Registr;
using System.Text.RegularExpressions;

namespace User_Interface.Login_page_mvp.Login.View.Registr
{
    public partial class RegistrForm : Form, IRegistrView
    {
        public RegistrForm()
        {
            InitializeComponent();
            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();
           
            // Resgistr button
            RegistrButton.Click += (s, e) => RegistrButtonClick?.Invoke();

            //back button
            GoBackButton.Click += (s, e) => GoBackButtonClick?.Invoke();

            //email field button
            EmailTextBox.Enter += (s, e) => EnterEmailTextBox?.Invoke();
            EmailTextBox.TextChanged += (s, e) => LeaveEmailBoxAndCheckCorrect?.Invoke(this, EmailTextBox.Text);
        }

        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;

        // Resgistr button
        public event Action? RegistrButtonClick;

        //back button
        public event Action? GoBackButtonClick;

        //email field button
        public event Action? EnterEmailTextBox;
        public event EventHandler<string>? LeaveEmailBoxAndCheckCorrect;

        public bool CheckCorrectInputEmail()
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(EmailTextBox.Text, emailPattern))
            {
                return true;
            }
            return false;
        }

        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

        public void MakeNotVisibleEmailerror()
        {
            EmailErrorPicture.Visible = false;
        }

        public void MakeVisibleEmailerror()
        {
            EmailErrorPicture.Visible = true;
        }
    }
}
