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
            CodeFieldTextBox.TextChanged += (s, e) => CodeFieldTextChenged?.Invoke(this, CodeFieldTextBox.);

            //enter code button
    }

        public event EventHandler<EventArgs>? CodeFieldTextChenged;
        public event Action? TgBotButtonClickClick;
        public event Action? LeaveCodeField;
        public event Action? CodeEnterButton;
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;

        public void MakeEnterCodeButtonEnable()
        {
            throw new NotImplementedException();
        }

        public void MakeEnterCodeEnterButtonDisable()
        {
            throw new NotImplementedException();
        }

        public void MakeErrorImageDisable()
        {
            throw new NotImplementedException();
        }

        public void MakeErrorImageEnable()
        {
            throw new NotImplementedException();
        }

        public void MakeExitButtonForeBlack()
        {
            throw new NotImplementedException();
        }

        public void MakeExitButtonForeRed()
        {
            throw new NotImplementedException();
        }
    }
}
