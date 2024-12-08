using Org.BouncyCastle.Tls.Crypto;
using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.SendCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.Login_page_mvp.ForgotPasswordPage.View
{
    public partial class EmailEnterfrom : Form, IViewEmailEnter
    {
        public EmailEnterfrom()
        {
            InitializeComponent();
            //exit button
            ExitButton.MouseEnter += (s, e) => EnterExitButton?.Invoke();
            ExitButton.MouseLeave += (s, e) => LeaveExitButton?.Invoke();
            ExitButton.Click += (s, e) => ExitForgotPageButtonClick?.Invoke();

            //email field
            EmailFieldTextBox.Enter += (s, e) => EnterEmailTextBox?.Invoke();
            EmailFieldTextBox.TextChanged += (s, e) => LeaveEmailBoxAndCheckCorrect?.Invoke(this, EmailFieldTextBox.Text);
            


            //send code button
            SendCodeButton.Click += (s, e) => SendCodeButtonClick?.Invoke();

        }

        public bool ImageErrorrVisible
        { 
            set 
            { 
                guna2ImageButton1.Visible = value;
                if (!value) SendCodeButton.Enabled = true;
            } 
        }
        //send code button
        public event Action? SendCodeButtonClick;

        //email field
        public event EventHandler<string>? LeaveEmailBoxAndCheckCorrect;
        public event Action? EnterEmailTextBox;

        //exit button
        public event Action? ExitForgotPageButtonClick;
        public event Action? EnterExitButton;
        public event Action? LeaveExitButton;

        public void MakeVisibleEmailerror()
        {
            guna2ImageButton1.Visible = true;
        }

        public void MakeNotVisibleEmailerror()
        {
            guna2ImageButton1.Visible=false;
        }

        public void MakeSendButtonEnable()
        {
            SendCodeButton.Enabled=true;
        }

        public void MakeSendButtonDisable()
        {
            SendCodeButton.Enabled = false;
        }

        public void MakeCloseButtonRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

        public void MakeCloseButtonBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public bool CheckCorrectInputEmail()
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(EmailFieldTextBox.Text, emailPattern))
            {
                return true;
            }
            return false;
        }
    }
}
