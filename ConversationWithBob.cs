using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Bob is a lackadaisical teenager. In conversation, his responses are very limited.
            Bob answers 'Sure.' if you ask him a question.
            He says 'Fine. Be that way!' if you address him without actually saying anything.
            He answers 'Whoa, chill out!' if you yell at him.
            He answers 'Whatever.' to anything else.*/

            string answer = "";
            do
            {
                Console.WriteLine($"Enter what you would like to say to Bob");
                string conversation = Console.ReadLine();
                string response = "";


                if (conversation.Contains("?"))
                {
                    response = "sure";
                    Console.WriteLine($"{response}");
                }
                else if (conversation == "")
                {
                    response = "Fine! Be that way.";
                    Console.WriteLine($"{response}");
                }
                else if (IsAllUpper(conversation))
                {
                    response = "Whoa, chill out!";
                    Console.WriteLine($"{response}");
                }
                else
                {
                    response = "Whatever";
                    Console.WriteLine($"{response}");
                }
                Console.WriteLine($"Do you want to continue to talk to Bob? Print y for yes or n for no.");
                answer = Console.ReadLine();

            } while (answer == "y" | answer == "Y");
               

        }

        static bool IsAllUpper(string conversation)
        {
            for (int i = 0; i < conversation.Length; i++)
            {
                if (!Char.IsUpper(conversation[i]))
                    return false;
            }

            return true;
        }
    }
}
