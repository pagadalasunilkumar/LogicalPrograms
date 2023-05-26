using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void Main()
        {
            int number = 12345; // Number to reverse

            int reversedNumber = ReverseNumber(number);

            Console.WriteLine($"Reversed number: {reversedNumber}");
        }

        public static int ReverseNumber(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }

            return reverse;
        }
    }
}
