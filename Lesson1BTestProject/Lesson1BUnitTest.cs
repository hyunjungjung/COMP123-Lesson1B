using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP123_Lesson1B.Program;


namespace Lesson1BTestProject
{
    [TestClass]
    public class Lesson1BUnitTest
    {
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //Arrange
            string outputString = "Enter UserName: ";
            bool hasnewLine = false;
            string actualResult;
            string expectedResult = "Enter UserName: ";

            //Act
            actualResult = OutputStringToConsole(outputString, hasnewLine);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
