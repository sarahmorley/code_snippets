using System;
using System.Linq;

namespace Museum
{
    public class ArraySmallestAndLargestElements
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[10] { 5, 3, 2, 1, 4, 1, 6, 6, 7, 7 };
            Console.WriteLine("This is the original array");
            foreach(var number in arrayOne)
            {
                Console.Write(number + " ");
            }

            var removeSmallestArray = RemoveSmallest(arrayOne);
            Console.Write(Environment.NewLine);
            Console.WriteLine("This is the array with the smallest element(s) removed");
            foreach(var number in removeSmallestArray)
            {
                Console.Write(number + " ");
            }

            var removeLargestArray = RemoveLargest(arrayOne);
            Console.Write(Environment.NewLine);
            Console.WriteLine("This is the array with the largest element(s) removed");
            foreach(var number in removeLargestArray)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }

        public static int[] RemoveSmallest(int[] array)
        {
            var min = array[0];
            foreach(var number in array)
            {
                if (min > number)
                    min = number;
            }

            array = array.Where(val => val != min).ToArray();
            return array;
        }

        public static int[] RemoveLargest(int[] array)
        {
            var max = array[0];
            foreach(var number in array)
            {
                if (max < number)
                    max = number;
            }

            array = array.Where(val => val != max).ToArray();
            return array;
        }

    }
}
