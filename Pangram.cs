using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
   public class Pangram
    {
        /* A Pangram is a sentence that contains every letter of the alphabet at least once.
           The following determines if a string given by the user is a pangram or not */
        
        static void Main(string[] args)
        {
            string ans = "";
            do
            {
                string sentence;

                Console.WriteLine($"Enter a sentence");
                sentence = Console.ReadLine().ToLower();
                bool result = CheckPangram(sentence);

                if (result)
                {
                    Console.WriteLine($"The sentence '{sentence}' is a Pangram\n");
                }
                else
                {
                    Console.WriteLine($"The sentence '{sentence}' is not a Pangram");
                }
                Console.WriteLine($"Do you wish to check another sentence?\nPrint Y for yes or any other character for no");
                ans = Console.ReadLine().ToLower();
            } while (ans == "y");

        }


        public static bool CheckPangram(string sentence)
        {
            string alphabet = "abcdefhgijklmnopqrstuvwxyz";

            if(sentence.Length < alphabet.Length)
            {
                return false;
            }      
                                     
            for (int i = 0; i < alphabet.Length; i++)
                {
                    if (sentence.Contains(alphabet[i]))
                    {
                    continue;
                    }
                    else
                    {
                        return false;
                    }
                }

            return true;                     
        }

    }   
}
