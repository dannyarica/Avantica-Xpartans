using Moq;
using NUnit.Framework;
using System;
using Xpartans.IFP.Business;

namespace Xpartans.IFP.Test
{
    [TestFixture]
    public class PersonControllerTest
    {
        [TestCase]
        public void TestPersonController_ValidateCSharpCode_ReturnOK_NoMoq()
        {
            //Arrange
            var oPersonaController = new PersonController(new ProgrammingLanguageCSharp());

            //Act
            var sentence = oPersonaController.GetCode();

            //Assert

            Assert.AreEqual("var cSharp = new CSharp();", sentence);
        }

        [TestCase]
        public void TestPersonController_ValidateCSharpCode_ReturnOK_Moq()
        {
            //Arrange
            var mockProgrammingLanguage = new Mock<IProgrammingLanguage>();

            mockProgrammingLanguage.Setup(m => m.WriteCodeDeclareVariable()).Returns("var cSharp = new CSharp();").Verifiable();
            var oPersonaController = new PersonController(mockProgrammingLanguage.Object);

            //Act
            var sentence = oPersonaController.GetCode();

            //Assert

            Assert.AreEqual("var cSharp = new CSharp();", sentence);
            mockProgrammingLanguage.Verify();
        }

        [TestCase]
        public void TestPersonController_ValidateCSharpCode_ReturnOK_MoqClass()
        {
            //Arrange
            var mockProgrammingLanguage = new Mock<ProgrammingLanguageCSharp>();
            mockProgrammingLanguage.CallBase = true;

            var oPersonaController = new PersonController(mockProgrammingLanguage.Object);

            //Act
            var sentence = oPersonaController.GetCode();

            //Assert

            Assert.AreEqual("var cSharp = new CSharp();", sentence);
        }

        [TestCase]
        //[ExpectedException(typeof(ArgumentException), ExpectedMessage = "expected message")]
        public void TestPersonController_ValidateCSharpCode_ReturnOK_MoqClass_ExceptionExpected()
        {
            //Arrange
            var mockProgrammingLanguage = new Mock<IProgrammingLanguage>();
            mockProgrammingLanguage.Setup(m => m.WriteCodeThrowException()).Throws<System.DivideByZeroException>();

            var oPersonaController = new PersonController(mockProgrammingLanguage.Object);

            //Act

            //Assert

            Assert.Throws<DivideByZeroException>(() => oPersonaController.GetCodeException());
        }
    }
}