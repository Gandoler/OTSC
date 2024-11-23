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
    public partial class ForgorPasswordForm : Form, IViewForgotPasswordPage
    {
        public ForgorPasswordForm()
        {
            InitializeComponent();
            guna2TextBoxEmail.Leave += (s, e) => EnterEmailOpenCodeField?.Invoke(guna2TextBoxEmail, EventArgs.Empty);
            guna2ButtonSendCode.Click += (s, e) => ButtonCheckCodeClick?.Invoke();
            guna2ButtonSaveNewPassword.Click += (s, e) => SaveNewPasswordButtonPress?.Invoke(this, EventArgs.Empty);
            buttonExit.Click += (s, e) => ExitButtonPress?.Invoke(this, EventArgs.Empty);
            guna2TextBoxEmail.Enter += (s,e) => EnterInEmailField?.Invoke();
        }


        public string EmailField
        {
            get
            {
                return guna2TextBoxEmail.Text;
            }

        }
        public string CodeField{
            get {
                return guna2TextBoxCode.Text;
            }
        }
        public string PasswordField
        {
            get
            {
                return guna2TextBoxPasswordOne.Text;
            }
        }
        public string PasswordSecondField
        {
            get
            {
                return PasswordSeconndTime.Text;
            }
        }


        public event EventHandler SaveNewPasswordButtonPress;
        public event EventHandler ExitButtonPress;
        public event EventHandler EnterEmailOpenCodeField;
        public event Action EnterInEmailField;
        public event Action EnterInPasswordBox;
        public event Action ButtonCheckCodeClick;

        public void ClearPasswords()
        {
            guna2TextBoxPasswordOne?.Clear();
            PasswordSeconndTime?.Clear();
            labelPswMissmatch.Visible = true;
        }

        public void DisableMissmatchLabel()
        {
            labelPswMissmatch.Visible = false;
        }

        public void MakeCodeFieldDisable()
        {
            guna2TextBoxCode.Enabled = false;
        }

        public void MakeCodeFieldEnable()
        {
            guna2TextBoxCode.Enabled = true;
        }

        public void RemakeWindow()
        {
            throw new NotImplementedException();
        }
    }
}
