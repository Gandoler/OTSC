using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.SendMailWithcode.CodeGenerate
{
    internal interface ICodeGeneratorMail
    {
        string GenerateCode() => new Random().Next(0, 10).ToString();

    }
}
