﻿using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-recursion
    /// </summary>
    class Day9_Recursion
    {
        public static void Main()
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
