using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP123_Lesson1B.Program;

/*Author : Joanne Hyunjung Jung
 * Date Created : May 13th, 2016
 * Date Modified : May 13th, 2016
 * Student ID : 300432364
 */
namespace Lesson1BTestProject
{
    /**
     * This clas is used to test the Lesson 1B Project
     * Used for development only.
     * 
     * @class Lesson1BUnitTest
     * 
     */
    [TestClass]
    public class Lesson1BUnitTest
    {
        /**
         * Unit Test for OutputStringToConsole Method of the Program class
         * 
         * @method OutputStringToConsoleTestMethod
         */
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
