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
            _mustSubscribeModel = mustSubscribeModel;



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
            _mustSubscribeView.CodeFieldEntered += _mustSubscribeView_CodeFieldEntered;

            //enter code button
            _mustSubscribeView.CodeEnterButtonClciked += MustSubscribeView_CodeEnterButtonClciked
                ;



            #endregion
        }




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
        private void _mustSubscribeView_CodeFieldEntered()
        {
            _mustSubscribeModel.GetCode();
        }


        //enter code button
        private void MustSubscribeView_CodeEnterButtonClciked()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
