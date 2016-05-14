using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author : Joanne Hyunjung Jung
 * Date Created : May 13th, 2016
 * Date Modified : May 13th, 2016
 * Student ID : 300432364
 * 
 * Description : This program demonstrates GitHub and version control 
 * best practice. We also explore Unit Testing
 * 
 * Version : 0.5 - Added Lesson1BUnitTest
 */
namespace COMP123_Lesson1B
{
    /**
     * This is the driver class for our program
     * 
     * @class Program
     */ 
    public class Program
    {
        /**
         * Main Method for class program
         * 
         * @param {string[]} args
         * @constructor Main
         */
        static void Main(string[] args)
        {
            GetuserName();
        }

        /**
         * This method reads the UserName from the Console
         * 
         * @method GetUserName
         * @return {string} UserName
         */
        public static string GetuserName()
        {
            //Initialize variables
            string UserName = "";

            OutputStringToConsole("Enter UserName: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n=======================\n");
            Console.WriteLine("You entered: " + UserName+ "\n");

            return UserName;

        }
        /**
         * This method writes a string to the console. Parameters allow the user to
         * choose to add a newLine character
         * 
         * @method OutputStringToConsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @return {string} outputString 
         */
        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            if (hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }

            return outputString;
        }
    }
}
