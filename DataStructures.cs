using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class DataStructures
    {
        static void Main(string[] args)
        {
            //Get the first person in the queue
            var firstPerson = ReturnTheFirstPersonFromQueue();

            //Get the book on the top of the stack
            var topBook = TopOfTheStack();

            //Get the price of the book
            var price = BookPrices(topBook.ToString());

            Console.WriteLine("{0} was first in the queue.\nShe gets to read the book on the top of the stack which is {1}.\nThis book cost {2}", firstPerson.ToString(), topBook.ToString(), price.ToString());
            Console.ReadLine();
        }

        static object ReturnTheFirstPersonFromQueue()
        {
            Queue personQueue = new Queue();
            personQueue.Enqueue("Sarah");
            personQueue.Enqueue("David");
            personQueue.Enqueue("Clare");
            
            //return the first person in the queue - and remove them from the queue
            object firstInQ = personQueue.Dequeue();
            return firstInQ;
        }

        static object TopOfTheStack()
        {
            Stack bookStack = new Stack();
            bookStack.Push("Transatlantic");
            bookStack.Push("Star of the Sea");
            bookStack.Push("Mrs Dalloway");

            //return the last book added to the stack but don't remove it from the stack
            object topOfTheStack = bookStack.Peek();
            return topOfTheStack;
        }

        static object BookPrices(string bookName)
        {
            Hashtable bookPrices = new Hashtable
            {
                { "Transatlantic", 12.99 },
                { "Star of the Sea", 14.99 },
                { "Mrs Dalloway", 5.99 }
            };

            var price = bookPrices[bookName];
            return price;
        }

    }
}
