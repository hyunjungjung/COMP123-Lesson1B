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
 * Version : 0.2 - Added GetUserName method
 */
namespace COMP123_Lesson1B
{
    class Program
    {
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

            Console.Write("Enter UserName: ");
            UserName = Console.ReadLine();
            Console.WriteLine("\n=======================");
            Console.WriteLine("You entered: " + UserName);

            return UserName;

        }
    }
}
