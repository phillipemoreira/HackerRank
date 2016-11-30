using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-generics
    /// </summary>
    class Day21_Generics
    {
        private static void printArray<T>(T[] _array)
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main()
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new[] { "Hello", "Word" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }
    }
}
