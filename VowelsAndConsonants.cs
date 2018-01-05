using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsAndConsonants
{
    class VowelsAndConsonants
    {
        static void Main(string[] args)
        {
            string word;
            string result;

            Console.WriteLine("Enter a word");
            word = Console.ReadLine();

            result = CountVowelsAndConsonantsIfElse(word);

            Console.WriteLine("{0}. {1}", word, result);
            Console.ReadLine();
        }

        // Count vowels, consonants and others using a if/else statements
        public static string CountVowelsAndConsonantsIfElse(string word)
        {
            int vowelCount = 0;
            int consonantCount = 0;
            int otherCount = 0;
            string countString;

            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    vowelCount++;
                }
                else if(word[i] >= 'a' && word[i] <= 'z' || word[i] >= 'A' && word[i] <= 'Z')
                {
                    consonantCount++;
                }
                else
                {
                    otherCount++;
                }
            }

            if(otherCount > 0)
            {
                countString = "Vowel Count = " + vowelCount + ". Consonant Count = " + consonantCount + ". Other Count = " + otherCount;
            }
            else
            {
                countString = "Vowel Count = " + vowelCount + ". Consonant Count = " + consonantCount;
            }

            return countString;
        }

        // Count vowels and consonants using a switch 
        public static string CountVowelsAndConsonantsSwitch(string word)
        {
            int vowelCount = 0;
            int consonantCount = 0;
            string countString;
            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'a':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'e':
                        vowelCount++;
                        break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        consonantCount++;
                        break;
                }
            }
            countString = "Vowel Count = " + vowelCount + ". Consonant Count = " + consonantCount;
            return countString;
        }
    }
}
