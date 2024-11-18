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
            textBoxPassword_def.Leave += (s, e) => leavePasswordTextBox?.Invoke(this, textBoxPassword_def.Text);
            textBoxPassword_def.KeyDown += (s, e) => leavePasswordTextBox?.Invoke(this, textBoxPassword_def.Text);
                
            // 
            // textBoxSecPasswordT
            // 
            textBoxSecPasswordT_def.Leave += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT_def.Text);
            textBoxSecPasswordT_def.KeyDown += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT_def.Text);
            // 
            // checkBoxSWhowPsw
            // 
            checkBoxSWhowPsw.CheckedChanged += (s, e) => show_Psw?.Invoke(this, checkBoxSWhowPsw.Checked);
            // 
            // buttonExit
            // 
            buttonExit.Click += (s, e) => ExitApl?.Invoke(this, EventArgs.Empty);
            // 
            // buttonEnter
            // 
            buttonEnter.Click += (s, e) => enter?.Invoke(this, EventArgs.Empty);
        }


        public string Password => textBoxPassword_def.Text;
        public string ConfirmPassword => textBoxSecPasswordT_def.Text;

        public string Login => textBoxLogin.Text;

        public event EventHandler<string> leavePasswordTextBox;
        public event EventHandler<bool> show_Psw;
        public event EventHandler ExitApl;
        public event EventHandler<string> leaveSecondPasswordTextBox;
        public event EventHandler<string> leaveLoginTextBox;
        public event EventHandler enter;

        public void BlockSecPsw()
        {
            textBoxSecPasswordT_def.Enabled = false;
        }

        public void ClearPasswords()
        {
            textBoxPassword_def.Text = "";
            textBoxSecPasswordT_def.Text = "";
            
        }

        public void ShowPasswordMismatchMessageBox(string message)
        {
            MessageBox.Show(message, "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowPsw()
        {
            textBoxSecPasswordT_def.UseSystemPasswordChar = false;
            textBoxPassword_def.UseSystemPasswordChar = false;

        }

        public void UnBlockSecPsw()
        {
            textBoxSecPasswordT_def.Enabled = true;
        }

        public void UnShowPsw()
        {
            textBoxSecPasswordT_def.UseSystemPasswordChar = true;
            textBoxPassword_def.UseSystemPasswordChar = true;

        }
    }
}
