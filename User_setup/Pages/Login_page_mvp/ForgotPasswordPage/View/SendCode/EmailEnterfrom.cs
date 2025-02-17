﻿using OTSC_ui.Pages.Login_page_mvp.ForgotPasswordPage.View.SendCode;
using System.Text.RegularExpressions;

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
            EmailFieldTextBox.TextChanged += (s, e) => LeaveEmailBoxAndCheckCorrect?.Invoke();
            


            //send code button
            SendCodeButton.Click += (s, e) => SendCodeButtonClick?.Invoke(this, EmailFieldTextBox.Text);

        }

       
        //send code button
        public event EventHandler<string>? SendCodeButtonClick;

        //email field
        public event Action? LeaveEmailBoxAndCheckCorrect;
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
