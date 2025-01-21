using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC_ui.Pages.Login_page_mvp.MustSubsribe.View;

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
            CodeFieldTextBox.KeyPress += (s, e) => CodeFieldKeyPressed?.Invoke(this, e);
            CodeFieldTextBox.Leave += (s, e) => LeaveCodeField?.Invoke();


            //enter code button
            CodeEnterButton.Click += (s, e) => CodeEnterButtonClciked?.Invoke(CodeFieldTextBox.Text);


            //send Code Button
            CodeSendButton.Enter += (s, e) => SendCodeButtonEntered?.Invoke();
            CodeSendButton.Leave += (s, e) => SendCodeButtonLeavd?.Invoke();
            CodeSendButton.Click += (s, e) => sendCodeButtonClick?.Invoke();


        }
        //tg button
        public event Action? TgBotButtonClickClick;

        //code Field
        public event EventHandler<KeyPressEventArgs>? CodeFieldKeyPressed;
        public event Action? LeaveCodeField;

        //enter code button
        public event Action<string>? CodeEnterButtonClciked;
        
        //exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;
        
        
        //send Code Button
        public event Action? sendCodeButtonClick;
        public event Action? SendCodeButtonEntered;
        public event Action? SendCodeButtonLeavd;

        public void CheckEmptyField()
        {
            if (CodeFieldTextBox.Text.Equals(""))
            {
                CodeFieldTextBox.Clear();
                CodeFieldTextBox.Refresh();
            }
        }

        public void MakeBackColorSendCodeBlue()
        {
            CodeSendButton.FillColor=Color.AliceBlue;
        }

        public void MakeBackColorSendCodeDefault()
        {
            CodeSendButton.FillColor=Color.FromArgb(201, 209, 200);
        }

        public void MakeEnterCodeButtonEnable()
        {
            CodeEnterButton.Enabled = true;
        }

        public void MakeEnterCodeEnterButtonDisable()
        {
            CodeEnterButton.Enabled = false;
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
