using Org.BouncyCastle.Tls.Crypto;
using OTSC_ui.Login_page_mvp.ForgotPasswordPage.View.SendCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            ExitButton.Enter += (s, e) => EnterExitButton?.Invoke(this, ExitButton.ForeColor);
            ExitButton.Leave += (s, e) => LeaveExitButton?.Invoke(this.ForeColor, ExitButton.ForeColor);
            ExitButton.Click += (s, e) => ExitForgotPageButtonClick?.Invoke();

            //email field
            EmailFieldTextBox.Enter += (s, e) => EnterEmailTextBox?.Invoke();
            EmailFieldTextBox.Leave += (s, e) => LeaveEmailBoxAndCheckCorrect?.Invoke(this, EmailFieldTextBox.Text);


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
        public event Action SendCodeButtonClick;

        //email field
        public event EventHandler<string> LeaveEmailBoxAndCheckCorrect;
        public event Action EnterEmailTextBox;

        //exit button
        public event Action ExitForgotPageButtonClick;
        public event EventHandler<Color> EnterExitButton;
        public event EventHandler<Color> LeaveExitButton;

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
    }
}
