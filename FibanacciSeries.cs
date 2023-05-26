using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibanacciSeries
    {
        public static void Main()
        {
            int n = 10; // Number of terms in the Fibonacci series

            // First two terms of the series
            int firstTerm = 0;
            int secondTerm = 1;

            Console.Write($"{firstTerm} {secondTerm}");

            for (int i = 2; i < n; i++)
            {
                int nextTerm = firstTerm + secondTerm;
                Console.Write($" {nextTerm}");

                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}
