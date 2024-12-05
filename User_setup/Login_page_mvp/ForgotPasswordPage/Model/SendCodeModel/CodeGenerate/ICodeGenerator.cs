using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.Model.SendCodeModel.CodeGenerate
{
    internal interface ICodeGenerator
    {
        string GenerateCode() => new Random().Next(0,10).ToString();

    }
}
