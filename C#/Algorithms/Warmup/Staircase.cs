using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/staircase
    /// </summary>
    class Staircase
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            printStaircase(n);
        }

        private static void printStaircase(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = size - i; j < size; j++)
                {
                    Console.Write("#");
                }

                if (i != size) Console.WriteLine();
            }
        }
    }
}
