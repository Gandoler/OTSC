using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.MustSubsribe.View
{
    internal interface IMustSubscribeView
    {
        //exit button
        event Action ExitButtonClick;
        event Action ExitButtonEntered;
        event Action ExitButtonLeavd;

        //tg button
        event Action TgBotButtonClickClick;


        //code Field
        event EventHandler<KeyPressEventArgs> CodeFieldKeyPressed;
        event Action LeaveCodeField;
        


        //enter code button
        event Action<string> CodeEnterButtonClciked;


        //send Code Button
        
        event Action sendCodeButtonClick;
        event Action SendCodeButtonEntered;
        event Action SendCodeButtonLeavd;




        //exit button
        void MakeExitButtonForeRed();
        void MakeExitButtonForeBlack();


        //code Field
        void CheckEmptyField();
        void MakeErrorImageVisibleTrue();
        void MakeErrorImageVisibleFalse();

        //enter code button
        void MakeEnterCodeButtonEnable();
        void MakeEnterCodeEnterButtonDisable();

        //send Code Button
        void MakeBackColorSendCodeBlue();
        void MakeBackColorSendCodeDefault();
    }
}
