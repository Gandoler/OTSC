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
        PresenterMustSubscribe(IMustSubscribeView mustSubscribeView, IMustSubscribeModel mustSubscribeModel)
        {
            _mustSubscribeModel = mustSubscribeModel;



            #region MustRegistr
            //init
            _mustSubscribeView = mustSubscribeView;

            //exit button
            _mustSubscribeView.ExitButtonClick += _mustSubscribeView_ExitButtonClick;
            _mustSubscribeView.ExitButtonEntered += _mustSubscribeView_ExitButtonEntered;
            _mustSubscribeView.ExitButtonLeavd += _mustSubscribeView_ExitButtonLeavd;

            //tg button
            _mustSubscribeView.TgBotButtonClickClick += _mustSubscribeView_TgBotButtonClickClick;


            //code Field
            _mustSubscribeView.CodeFieldKeyPressed += _mustSubscribeView_CodeFieldTextChenged;
            _mustSubscribeView.LeaveCodeField += _mustSubscribeView_LeaveCodeField;


            //enter code button
            _mustSubscribeView.CodeEnterButtonClciked += _mustSubscribeView_CodeEnterButtonClciked
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
                    thisformMustRegisr.Hide();
                }
            }
        }

        private void _mustSubscribeView_ExitButtonEntered()
        {
            _mustSubscribeView.MakeExitButtonForeRed();
        }
        private void _mustSubscribeView_ExitButtonLeavd()
        {
            _mustSubscribeView.MakeExitButtonForeBlack();
        }


        //tg button
        private void _mustSubscribeView_TgBotButtonClickClick()
        {
            string url = "t.me/HappyBDay_OTSC_bot";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }


        //code Field
        private void _mustSubscribeView_CodeFieldTextChenged(object? sender, KeyPressEventArgs e)
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
        private void _mustSubscribeView_CodeEnterButtonClciked()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
