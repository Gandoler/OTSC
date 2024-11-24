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
    public partial class SendCodeForm : Form, IViewForgotPasswordPage
    {
        public SendCodeForm()
        {
            InitializeComponent();
            //FOR ALL
            //
            // Exit from application
            buttonExit.Click += (s, e) => Exit_Aplicatiom?.Invoke(this, EventArgs.Empty);


            //FOR CODE ENTER
            //
            // User had been Entered his email (Field for code must be enable)
            guna2ButtonSendCode.Click += (s, e) => ButtonConfirmCode?.Invoke();
            // User Change his Email
            guna2TextBoxEmail.Enter += (s, e) => ChangeEmail?.Invoke();
            // User input code and press 
            


            
           
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

        public event EventHandler Exit_Aplicatiom;
        public event EventHandler User_Enter_EMAIL;
        public event Action ChangeEmail;
        public event Action ButtonConfirmCode;
        public event EventHandler Save_New_Password;

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
