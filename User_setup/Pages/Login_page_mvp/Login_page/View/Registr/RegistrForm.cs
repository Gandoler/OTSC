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
            EmailTextBox.TextChanged += (s, e) => LeaveEmailBoxAndCheckCorrect?.Invoke(this, EmailTextBox.Text);


            //for all field EXCEPT email
            //For Enter
            EmailTextBox.Enter += (s, e) => EnterInField?.Invoke();
            LoginTextBox.Enter += (s, e) => EnterInField?.Invoke();
            PasswordTextBox.Enter += (s, e) => EnterInField?.Invoke();
            SeccondPasswordTextBox.Enter += (s, e) => EnterInField?.Invoke();


            //For text changed
            LoginTextBox.TextChanged += (s, e) => TextChengedInFieldExceptEmail?.Invoke();
            PasswordTextBox.TextChanged += (s, e) => TextChengedInFieldExceptEmail?.Invoke();
            SeccondPasswordTextBox.TextChanged += (s, e) => TextChengedInFieldExceptEmail?.Invoke();

        }
        //for all field EXCEPT email
        public event Action? EnterInField;
        public event Action? TextChengedInFieldExceptEmail;


        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;

        // Resgistr button
        public event Action? RegistrButtonClick;

        //back button
        public event Action? GoBackButtonClick;

        //email field button
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

        public bool CheckForAllFieldsNotEmpty()
        {
            if (CheckCorrectInputEmail() || string.IsNullOrWhiteSpace(EmailTextBox.Text)
                || string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(SeccondPasswordTextBox.Text))
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

        public void MakeRegistrButtonDisable()
        {
            RegistrButton.Enabled = false;
        }

        public void MakeRegistrButtonEnable()
        {
            RegistrButton.Enabled = true;
        }

        public void MakeVisibleEmailerror()
        {
            EmailErrorPicture.Visible = true;
        }
    }
}
