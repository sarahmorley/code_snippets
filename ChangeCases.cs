using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchLowerAndUpperCases
{
    class ChangeCases
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert and word or sentence with both upper and lower case letters.");
            string word = Console.ReadLine();
            int length = word.Length;
            char[] letterArray = word.ToCharArray(0, length);
            char letter;

            for(int i = 0; i < length; i++)
            {
                letter = letterArray[i];
                if(Char.IsLower(letter))
                {
                    Console.Write(Char.ToUpper(letter));
                }
                else
                {
                    Console.Write(Char.ToLower(letter));
                }
            }
        }
    }
}
