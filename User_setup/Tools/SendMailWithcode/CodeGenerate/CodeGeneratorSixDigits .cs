﻿namespace OTSC_ui.Tools.SendMailWithcode.CodeGenerate
{
    internal class CodeGeneratorsix : ICodeGeneratorMail
    {

        public string GenerateCode()
        {
            return new Random().Next(100000, 999999).ToString();
        }
    }
}
