using OTSC_ui.Pages.Login_page_mvp.MustSubsribe.Model;
using OTSC_ui.Pages.Login_page_mvp.MustSubsribe.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.MustSubsribe
{
    internal class PresenterMustSubscribe
    {

        private readonly IMustSubscribeView _mustSubscribeView;
        private readonly IMustSubscribeModel _mustSubscribeModel;
        public PresenterMustSubscribe(IMustSubscribeView mustSubscribeView, IMustSubscribeModel mustSubscribeModel)
        {
            #region Model

            _mustSubscribeModel = mustSubscribeModel;
            _mustSubscribeModel.CodeIncorect += _mustSubscribeModel_CodeIncorect;
            _mustSubscribeModel.CodeCorrect += _mustSubscribeModel_CodeСorect;

            #endregion

            #region MustRegistr
            //init
            _mustSubscribeView = mustSubscribeView;

            //exit button
            _mustSubscribeView.ExitButtonClick += _mustSubscribeView_ExitButtonClick;
            _mustSubscribeView.ExitButtonEntered += MustSubscribeView_ExitButtonEntered;
            _mustSubscribeView.ExitButtonLeavd += MustSubscribeView_ExitButtonLeavd;

            //tg button
            _mustSubscribeView.TgBotButtonClickClick += MustSubscribeView_TgBotButtonClickClick;


            //code Field
            _mustSubscribeView.CodeFieldKeyPressed += MustSubscribeView_CodeFieldTextChenged;
            _mustSubscribeView.LeaveCodeField += _mustSubscribeView_LeaveCodeField;
            

            //enter code button
            _mustSubscribeView.CodeEnterButtonClciked += MustSubscribeView_CodeEnterButtonClciked;

            //send Code Button
            _mustSubscribeView.SendCodeButtonLeavd += () => _mustSubscribeView.MakeBackColorSendCodeDefault();
            _mustSubscribeView.SendCodeButtonEntered += () => _mustSubscribeView.MakeBackColorSendCodeBlue();
            _mustSubscribeView.sendCodeButtonClick += _mustSubscribeView_sendCodeButtonClick;

            #endregion
        }



        #region ModelFunc
        private void _mustSubscribeModel_CodeIncorect()
        {
            MessageBox.Show("Code Mismatch", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _mustSubscribeModel_CodeСorect()
        {
            if(this._mustSubscribeView is Form ThisForm){
                ThisForm.DialogResult = DialogResult.OK;
                ThisForm.Close();

            }
        }
        #endregion






        #region MustSub
        //exit button
        private void _mustSubscribeView_ExitButtonClick()
        {
            //model performance
            if (true)
            {
                if (_mustSubscribeView is Form thisformMustRegisr)
                {
                    thisformMustRegisr.Close();
                }
            }
        }

        private void MustSubscribeView_ExitButtonEntered()
        {
            _mustSubscribeView.MakeExitButtonForeRed();
        }
        private void MustSubscribeView_ExitButtonLeavd()
        {
            _mustSubscribeView.MakeExitButtonForeBlack();
        }


        //tg button
        private void MustSubscribeView_TgBotButtonClickClick()
        {
            _mustSubscribeModel.GoLink();
        }


        //code Field
        private void MustSubscribeView_CodeFieldTextChenged(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
        private void _mustSubscribeView_LeaveCodeField()
        {
            _mustSubscribeView.CheckEmptyField();
        }
       


        //enter code button
        private void MustSubscribeView_CodeEnterButtonClciked(string input)
        {
            _mustSubscribeModel.CheckCode(input);
        }
        
        
        //send Code Button
        private void _mustSubscribeView_sendCodeButtonClick()
        {
            _mustSubscribeModel.GetCodeHttp();
        }
        #endregion

    }
}
