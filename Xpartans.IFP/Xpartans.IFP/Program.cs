using System;
using Xpartans.IFP.Business;

namespace Xpartans.IFP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var oCSharpDeveloper = new PersonController(new ProgrammingLanguageCSharp());
            Console.WriteLine(oCSharpDeveloper.GetCode());

            var oVisualBasicDeveloper = new PersonController(new ProgrammingLanguageVB());
            Console.WriteLine(oVisualBasicDeveloper.GetCode());
        }
    }
}