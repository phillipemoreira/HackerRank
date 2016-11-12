using System;

namespace HackerRank
{
    class Day9_Recursion
    {
        public static void Main(String[] args)
        {
            var N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(factorial(N));
        }

        private static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n - 1);
            }

            return 1;
        }
    }
}
