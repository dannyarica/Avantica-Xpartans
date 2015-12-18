namespace Xpartans.IFP.Business
{
    public class ProgrammingLanguageCSharp : IProgrammingLanguage
    {
        public string WriteCodeDeclareVariable()
        {
            return "var cSharp = new CSharp();";
        }        

        public string WriteCodeThrowException()
        {
            throw new System.DivideByZeroException();
        }
    }
}