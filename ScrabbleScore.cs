using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleScore
{
   public class Scrabble
    {
        static void Main(string[] args)
        {
  
            string ans = "";
            do
            {
                Console.WriteLine($"Enter a word to get the Scrabble Score: ");

                string scrabbleWord = Console.ReadLine().ToLower();
                int score = GetLetterPoints(scrabbleWord);

                Console.WriteLine($"The score for {scrabbleWord} is {score}.\n");
                Console.WriteLine($"Do you want to check the score of another word?\nEnter y for Yes or any other letter for no");
                ans = Console.ReadLine();

            } while (ans == "y" | ans == "Y");



        }

        public static int GetLetterPoints(string scrabbleWord)
        {
            int score = 0;
            foreach (char letter in scrabbleWord)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'l':
                    case 'n':
                    case 'r':
                    case 's':
                    case 't':
                        score += 1;
                        break;
                    case 'd':
                    case 'g':
                        score += 2;
                        break;
                    case 'b':
                    case 'c':
                    case 'm':
                    case 'p':
                        score += 3;
                        break;
                    case 'f':
                    case 'h':
                    case 'v':
                    case 'w':
                    case 'y':
                        score += 4;
                        break;
                    case 'k':
                        score += 5;
                        break;
                    case 'j':
                    case 'x':
                        score += 8;
                        break;
                    case 'q':
                    case 'z':
                        score += 10;
                        break;
                }

            }
            return score;
        }
    }
}

