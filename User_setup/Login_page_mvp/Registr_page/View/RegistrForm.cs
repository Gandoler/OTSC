using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Interface.Login_page_mvp.Registr_page.View;

namespace User_Interface.Login_page_mvp.Login.View.Registr
{
    public partial class RegistrForm : Form, IRegistrView
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        public string Login => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public string ConfirmPassword => throw new NotImplementedException();

        public event EventHandler ExitApl;
        public event EventHandler<string> leaveLEmailTextBox;
        public event EventHandler<string> leavePasswordTextBox;
        public event EventHandler<string> leaveSecondPasswordTextBox;
        public event EventHandler<string> leaveLoginTextBox;
        public event EventHandler<bool> show_Psw;
        public event EventHandler enter;
        public event EventHandler<EventArgs> charKeyPresd;

        public void BlockSecPsw()
        {
            throw new NotImplementedException();
        }

        public void ClearPasswords()
        {
            throw new NotImplementedException();
        }

        public void ShowPasswordMismatchMessageBox(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowPsw()
        {
            throw new NotImplementedException();
        }

        public void UnBlockSecPsw()
        {
            throw new NotImplementedException();
        }

        public void UnShowPsw()
        {
            throw new NotImplementedException();
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {

        }
    }
}
