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
    public partial class formLogin : Form, ILoginView
    {
        public formLogin()
        {
            InitializeComponent();
            textBoxLogin.Leave += (s, e) => leaveLoginTextBox?.Invoke(this, textBoxLogin.Text);
            textBoxPassword.Leave += (s, e) => leavePasswordTextBox?.Invoke(this, textBoxPassword.Text);
            textBoxSecPasswordT.Leave += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT.Text);
            checkBoxSWhowPsw.Click += (s, e) => clickTextBox?.Invoke(this, checkBoxSWhowPsw.Checked);
            buttonExit.Click += (s, e) => ExitApl?.Invoke(this, EventArgs.Empty);

        }




        

        public event EventHandler<string> leavePasswordTextBox;
        public event EventHandler<bool> clickTextBox;
        public event EventHandler ExitApl;
        public event EventHandler<string> leaveSecondPasswordTextBox;
        public event EventHandler<string> leaveLoginTextBox;
    }
}
