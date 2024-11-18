using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.Login_page_mvp.View
{
    internal partial class formLogin : Form, ILoginView
    {
        public formLogin()
        {
            InitializeComponent();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Leave += (s, e) => leaveLoginTextBox?.Invoke(this, textBoxLogin.Text);
            // 
            // textBoxPassword
            // 
            textBoxPassword.Leave += (s, e) => leavePasswordTextBox?.Invoke(this, textBoxPassword.Text);
            textBoxPassword.KeyDown += (s, e) => leavePasswordTextBox?.Invoke(this, textBoxPassword.Text);

            // 
            // textBoxSecPasswordT
            // 
            textBoxSecPasswordT.Leave += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT.Text);
            textBoxSecPasswordT.KeyDown += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT.Text);
            // 
            // checkBoxSWhowPsw
            // 
            checkBoxSWhowPsw.Click += (s, e) => show_Psw?.Invoke(this, checkBoxSWhowPsw.Checked);
            // 
            // buttonExit
            // 
            buttonExit.Click += (s, e) => ExitApl?.Invoke(this, EventArgs.Empty);
            // 
            // buttonEnter
            // 
            buttonEnter.Click += (s, e) => enter?.Invoke(this, EventArgs.Empty);
        }


        public string Password => textBoxPassword.Text;
        public string ConfirmPassword => textBoxSecPasswordT.Text;

        public string Login => textBoxLogin.Text;

        public event EventHandler<string> leavePasswordTextBox;
        public event EventHandler<bool> show_Psw;
        public event EventHandler ExitApl;
        public event EventHandler<string> leaveSecondPasswordTextBox;
        public event EventHandler<string> leaveLoginTextBox;
        public event EventHandler enter;

        public void BlockSecPsw()
        {
            textBoxSecPasswordT.Enabled = false;
        }

        public void ClearPasswords()
        {
            textBoxPassword.Text = "";
            textBoxSecPasswordT.Text = "";
            
        }

        public void ShowPasswordMismatchMessageBox(string message)
        {
            MessageBox.Show(message, "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowPsw()
        {
           
        }

        public void UnBlockSecPsw()
        {
            textBoxSecPasswordT.Enabled = true;
        }

        public void UnShowPsw()
        {
            throw new NotImplementedException();
        }
    }
}
