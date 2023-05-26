using System;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public PerfectNumber()
        {
            int number = 28; // Number to check if it's a perfect number

            bool isPerfectNumber = CheckPerfectNumber(number);

            if (isPerfectNumber)
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }

        public static bool CheckPerfectNumber(int number)
        {
            int sumOfDivisors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            return sumOfDivisors == number;
        }
    }
}

