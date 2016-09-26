using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Design_and_Programming_Assignment
{
    class SecretNumber
    {
        static void Main(string[] args)
        {
            // declartion of variables
            Random random = new Random();
            int secretNum = random.Next(0, 20); 
            int guess = 0;

            // start of for loop
            // decalre int attempt and set as 0 (initial condition), 
            // while attempt is less that 3 (test condition),
            // increment attempt by 1 (update condition).
            for (int attempt = 0; attempt < 3; attempt++)
            {
                // Prompt user to guess a number and try parse to int guess, catch if letter entered and display error. 
                Console.WriteLine("Try to guess the secret number between 0 and 20. You have {0} attempt(s) left.", 3 - attempt);
                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error: You must enter a number.\n");
                    continue;  // count as an attempt and skip to the next iteration in the loop
                }
                // if guess is correct display and break out of loop
                if (guess == secretNum)
                {
                    Console.WriteLine("Well done, you guessed correctly.");
                    break;  // break out of loop now
                }
                // else if guess is less than 5 display
                else if (guess < secretNum)
                {
                    Console.WriteLine("Your guess is too low.\n");
                }

                // else if guess is greater than 5 display
                else if (guess > secretNum)
                {
                    Console.WriteLine("Your guess is too high.\n");
                }
            }
            // after 3 attempts if guess is not correct display
            if (guess != secretNum)
            {
                Console.WriteLine("Hard luck, the number was {0}", secretNum);
            }
            Console.ReadLine();
        }
    }
}
