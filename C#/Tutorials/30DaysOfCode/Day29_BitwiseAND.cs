using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-bitwise-and
    /// </summary>
    class Day29_BitwiseAND
    {
        public static void Main()
        {
            // 1 <= T <= 10^3
            var T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                var token = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

                // 2 <= N <= 10^3
                var N = token[0];

                // 2 <= K <= N
                var K = token[1];

                Console.WriteLine(FindGreatestBitwisePairInSThatIsSmallerThanK(N, K));
            }
        }

        private static int FindGreatestBitwisePairInSThatIsSmallerThanK(int N, int K)
        {
            var greatestPossible = 0;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    var and = i & j;
                    if (and > greatestPossible && and < K)
                    {
                        greatestPossible = and;
                    }
                }
            }

            return greatestPossible;
        }
    }
}
