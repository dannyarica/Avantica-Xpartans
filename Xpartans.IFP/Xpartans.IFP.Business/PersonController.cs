namespace Xpartans.IFP.Business
{
    public class PersonController
    {
        private readonly IProgrammingLanguage _programmingLanguage;

        public PersonController(IProgrammingLanguage programmingLanguage)
        {
            _programmingLanguage = programmingLanguage;
        }

        public string GetCode()
        {
            return _programmingLanguage.WriteCodeDeclareVariable();
        }

        public string GetCodeException()
        {
            return _programmingLanguage.WriteCodeThrowException();
        }
    }
}