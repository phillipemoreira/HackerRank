using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/diagonal-difference
    /// </summary>
    class DiagonalDifference
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            //Sum of first diagonal
            var sumFirstD = 0;
            for (int i = 0; i < n; i++)
            {
                sumFirstD += a[i][i];
            }

            //Sum of second diagonal
            var sumSecondD = 0;
            for (int i = 0; i < n; i++)
            {
                sumSecondD += a[i][n - i - 1];
            }

            var p1 = sumFirstD - sumSecondD;
            var p2 = sumSecondD - sumFirstD;

            var diagonalDiff = p1 < p2 ? p1 : p2;

            if (diagonalDiff < 0) diagonalDiff *= -1;

            Console.WriteLine(diagonalDiff);
        }
    }
}
