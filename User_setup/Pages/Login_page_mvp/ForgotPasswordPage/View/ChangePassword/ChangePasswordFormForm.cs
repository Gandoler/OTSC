using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.ChangePassword;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.View
{
    public partial class ChangePasswordFormForm : Form, IViewChangePasswod
    {
       
        public ChangePasswordFormForm()
        {
            InitializeComponent();

            //exit and back buttons
            GoBackButton.Click += (s, e) => GoBackButtonCLick?.Invoke();
            ExitButton.Enter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.Leave += (s, e) => ExitButtonLeavd?.Invoke();
            ExitButton.Click += (s, e) => ExitForgotpageButtonClick?.Invoke();

            //fields
            FirstPasswordField.Enter += (s, e) => EnterInPassswordsFields?.Invoke();
            SecondPasswordField.Enter += (s, e) => EnterInPassswordsFields?.Invoke();
            CodeFieldTextBox1.Leave += (s, e) => LeaveCodeField?.Invoke(this,CodeFieldTextBox1.Text);
            //buton confirm
            SaveNewPasswordButton.Click += (s, e) => Save_New_Password_buttonClick?.Invoke(this, (FirstPasswordField.Text, SecondPasswordField.Text));

        }

       
        //exit and back buttons
        public event Action? ExitForgotpageButtonClick;
        public event Action? GoBackButtonCLick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;

        //fields
        public event EventHandler<string>? LeaveCodeField;
        public event Action? EnterInPassswordsFields;
        
        //buton confirm
        public event EventHandler<(string, string)>? Save_New_Password_buttonClick;

        public void ClearPasswords()
        {
            FirstPasswordField.Clear();
            SecondPasswordField.Clear();
        }

        public void DisablepasswordSField()
        {
            FirstPasswordField.Enabled = false;
            SecondPasswordField.Enabled = false;
        }

        public void EnablepasswordSField()
        {
            FirstPasswordField.Enabled = true;
            SecondPasswordField.Enabled = true;
        }

        public void MakeNotVisibleErrorLable()
        {
            PswMissmatchLabel.Visible = false;
        }

        public void MakeVisibleErrorLable()
        {
            PswMissmatchLabel.Visible = true;

        }

        public void MakeCloseButtonRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

        public void MakeCloseButtonBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }
    }
}
