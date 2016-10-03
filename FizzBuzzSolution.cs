using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolution
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /* Question = Print the numbers 1 to 100 
               for multiples of 3 print the word "fizz"
               for multiples of 5 print the word "buzz"
            */

          //use a for loop to print 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

          // if i divided by 3 is equal to zero then print "fizz"
                if (i % 3 == 0)
                {
                    output = "fizz";
                }
          // if i divided by 5 is equal to zero then print "buzz"
                if(i % 5 == 0)
                {
                    // use += here to say that if i is divisible by both 3 and 5 print fizz and buzz ("fizzbuzz")
                    output += "buzz"; 
                }

          // not divisible by either 3 or 5 print out the number
                if(output == "")
                {
                    output = i.ToString();
                }


                Console.WriteLine(output); 


            }
      

        }
    }
}
