using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.SendMailWithcode.CodeGenerate
{
    internal class CodeGeneratorsix : ICodeGeneratorMail
    {

        public string GenerateCode()
        {
            return new Random().Next(100000, 999999).ToString();
        }
    }
}
