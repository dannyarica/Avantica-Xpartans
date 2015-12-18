namespace Xpartans.IFP.Business
{
    public class ProgrammingLanguageVB : IProgrammingLanguage
    {
        public string WriteCodeDeclareVariable()
        {
            return "Dim oVisualBasic As New VBasic()";
        }
        
        public string WriteCodeThrowException()
        {
            return "New Exception()";
        }
    }
}