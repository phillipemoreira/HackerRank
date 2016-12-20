using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-running-time-and-complexity
    /// </summary>
    class Day25_RunningTimeAndComplexity
    {
        public static void Main()
        {
            var numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                var N = Convert.ToInt32(Console.ReadLine());

                if (IsPrime(N))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }

        static bool IsPrime(int N)
        {
            if (N == 1) return false;

            for (int i = 2; i < N; i++)
            {
                // This lines makes the algorithm O(squareRoot(N))
                if (i * i > N) break;

                if (N % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
