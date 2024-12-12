using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC_ui.Pages.Login_page_mvp.Login_page.View.MustSubsribe;

namespace OTSC_ui.Pages.Login_page_mvp.Login_page.MustSubsribe
{
    public partial class MustSubscribeForm : Form, IMustSubscribeView
    {
        public MustSubscribeForm()
        {
            InitializeComponent();


            //exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.Enter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.Leave += (s, e) => ExitButtonLeavd?.Invoke();


            //tg button
            TgButton.Click += (s, e) => TgBotButtonClickClick?.Invoke();


            //code Field
            CodeFieldTextBox.TextChanged += (s, e) => CodeFieldTextChenged?.Invoke(this, e);
            CodeFieldTextBox.Leave += (s, e) => LeaveCodeField?.Invoke();

            //enter code button
            EnterCodeButton.Click += (s, e) => CodeEnterButtonClciked?.Invoke();
    }

        public event EventHandler<EventArgs>? CodeFieldTextChenged;
        public event Action? TgBotButtonClickClick;
        public event Action? LeaveCodeField;
        public event Action? CodeEnterButtonClciked;
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;

        public void MakeEnterCodeButtonEnable()
        {
            EnterCodeButton.Enabled = true;
        }

        public void MakeEnterCodeEnterButtonDisable()
        {
            EnterCodeButton.Enabled = false;
        }

        public void MakeErrorImageVisibleFalse()
        {
            ErrorImage.Visible = false;
        }

        public void MakeErrorImageVisibleTrue()
        {
            ErrorImage.Visible = true;
        }

        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }
    }
}
