using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Design_and_Programming_Assignment
{
    class Leap_Year
    {
        static void Main(string[] args)
        {
            // declaration of variables
            int year = 0;
            bool valid = false;

            // while loop statement until valid year format 
            while (!valid)
            {
                // prompt user to enter a year
                Console.WriteLine("Enter a Year (YYYY):");

                // try parse to int, catch if cannot parse to int (eg. user entered letter) and assign 0, 
                // this way program won't crash
                try
                {
                    year = int.Parse(Console.ReadLine());
                }
                catch
                {
                    year = 0;
                }
                // if valid year entered move on, else prompt user that year entered is invalid
                if ((year >= 1000) && (year <= 9999))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("You have enter an invalid year format");
                }
            }
            // calculation = if year is evenly divisable by 4, expect if evenly divisable by 100,
            // expect if evenly divisable by 400
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {             
                Console.WriteLine("The year {0} is a leap year", year);
            }
            else
            {              
                Console.WriteLine("The year {0} is not a leap year", year);
            }
            Console.ReadLine();
        }
    }
}
