using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine($"Enter the word you wish to test: ");
            string str = Console.ReadLine();
 
            Console.WriteLine(IsPalindrome(str));             
                       
       }


        public static bool IsPalindrome(string str)
        {
            for(int x = str.Length -1, y = 0; x > y; x--, y++)
            {
                if (str[x] != str[y])
                    return false;
            }

            return true; 
        }   

       
    }
}
