using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAWord
{
    class ReverseWord
    {
        static void Main(string[] args)
        {
            
            //int length;
            string answer = "";

            do
            {
                string word;
                string reverseWord = "";

                Console.WriteLine("Enter the word you wish to reverse.");
                word = Console.ReadLine();

                //length = word.Length - 1;

                //while (length >= 0)
                //{
                //    reverseWord = reverseWord + word[length];
                //    length--;
                //}

                foreach(char letter in word)
                {
                    reverseWord = letter + reverseWord;
                }

                Console.WriteLine("{0} reversed is {1}", word, reverseWord);

                Console.WriteLine("Would you like to reverse another word? Enter 'Y' for yes of any other key for No.");
                answer = Console.ReadLine();

            } while (answer == "Y");
       
        }
    }
}
