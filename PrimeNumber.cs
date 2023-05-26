using System;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void prime()
        {
            int number = 17; // Number to check if it's a prime number

            bool isPrime = CheckPrimeNumber(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        public static bool CheckPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
