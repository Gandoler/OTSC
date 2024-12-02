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
        }

        public string EmailField => throw new NotImplementedException();

        public event EventHandler LeaveEmailBoxCheckCorrect;
        public event Action EnterSendCodeButton;
        public event Action LeaveForgotpage;

        public void NextPage()
        {
            throw new NotImplementedException();
        }
    }
}
