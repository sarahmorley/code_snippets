using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class LinkedLists
    {
        static void Main(string[] args)
        {
            string[] sentence = { "Hello", "Mr/Ms" };

            Console.WriteLine("Please enter your surname: ");
            var surname = Console.ReadLine();

            var fullSentence = AddLastToLinkedList(surname, sentence);
            PrintOutSentence(fullSentence);

            Console.WriteLine("Please enter your first name: ");
            var firstName = Console.ReadLine();

            fullSentence = AddBeforeLinkedList(firstName, surname, fullSentence);
            PrintOutSentence(fullSentence);

            Console.WriteLine("Please enter your title: (Mr/Ms) ");
            var title = Console.ReadLine();

            fullSentence = RemoveFromLinkedListAndAddAfter(title, fullSentence);
            PrintOutSentence(fullSentence);

            Console.ReadLine();
        }

        static LinkedList<string> AddLastToLinkedList(string surname, string[] sentence)
        {        
            LinkedList<string> sentenceWords = new LinkedList<string>(sentence);
            sentenceWords.AddLast(surname);
            return sentenceWords;
        }

        static LinkedList<string> AddBeforeLinkedList(string firstName, string surname, LinkedList<string> fullSentence)
        {           
            LinkedListNode<string> surnameNode = fullSentence.Find(surname);
            fullSentence.AddBefore(surnameNode, firstName);
            return fullSentence;
        }

        static LinkedList<string> RemoveFromLinkedListAndAddAfter(string title, LinkedList<string> fullSentence)
        {
            fullSentence.Remove("Mr/Ms");
            LinkedListNode<string> helloNode = fullSentence.Find("Hello");
            fullSentence.AddAfter(helloNode, title);
            return fullSentence;

        }

        private static void PrintOutSentence(LinkedList<string> sentence)
        {
            foreach (string word in sentence)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
