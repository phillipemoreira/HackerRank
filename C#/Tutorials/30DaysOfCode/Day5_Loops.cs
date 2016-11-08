using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-loops
    /// </summary>
    class Day5_Loops
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i ++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}", n, i, n*i));
            }
        }
    }
}
