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
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Login_text { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public string Password_text { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }

        public void UpdateUI()
        {
            throw new NotImplementedException();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
