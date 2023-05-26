namespace LogicalPrograms
{
    internal class Program
    {
        public static void GenerateFibonacciSeries(int n)
        {
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