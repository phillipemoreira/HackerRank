using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/sock-merchant
    /// </summary>
    class SockMerchant
    {
        public static void Main()
        {
            Console.ReadLine();
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            var result = CalculateNumberOfMatchingPairs(c);

            Console.WriteLine(result);
        }

        static int CalculateNumberOfMatchingPairs(int[] socks)
        {
            var colors = new int[100];
            foreach (var sock in socks)
            {
                colors[sock-1]++;
            }

            var totalOfPairs = 0;
            foreach (var item in colors)
            {
                totalOfPairs += item / 2;
            }

            return totalOfPairs;
        }
    }
}
