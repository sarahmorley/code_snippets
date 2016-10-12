using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            // print out the Fibonacci Sequence - length determined by user input

            Console.WriteLine($"Enter the length of the Fibonacci sequence you want:");
            int length = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.WriteLine($"{a}, {b}");

            for (int i = 0; i < length; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine($"{c}");
            }

            /* print out nth number in the Fibonacci sequence by calling the method below 
            nth number determined by user input*/

            Console.WriteLine($"Enter the number in the Fibonacci sequence you wish to access");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNthFibonacciNo(n));
        }


            // method to print out the nth number in the Fibonacci sequence 

            public static int GetNthFibonacciNo (int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int number = n - 1;
                int[] fibonacci = new int[number + 1];
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 2; i <= number; i++)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }

                return fibonacci[number];
        }
 
        
    }
}
