using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorAndCeilingDecimals
{
    class RoundDecimals
    {
        static void Main(string[] args)
        {
            decimal decimalNumber;

            Console.WriteLine("Insert a decimal");
            decimalNumber = Decimal.Parse(Console.ReadLine());

            var flooredDecimal = Decimal.Floor(decimalNumber);
            var ceilingedDecimal = Decimal.Ceiling(decimalNumber);

            Console.WriteLine("Decimal: {0}, Floor: {1}, Ceiling {2}", decimalNumber, flooredDecimal, ceilingedDecimal);
            Console.ReadLine();
        }
    }
}
