using System;
using System.Collections.Generic;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-binary-numbers
    /// </summary>
    class Day10_BinaryNumbers
    {
        public static void Main()
        {
            // Read the decimal number.
            var n = Convert.ToInt32(Console.ReadLine());

            // Get the Binary string.
            var binaryString = Int2BinaryString(n);

            // Find the maximum number of consecutive '1's in the string.
            var maxNumberOfConsecutive1s = GetMaxNumberOfConsecutive1s(binaryString);

            // Print out the result'.
            Console.WriteLine(maxNumberOfConsecutive1s);
        }

        private static int GetMaxNumberOfConsecutive1s(string _binaryString)
        {
            int maxNumberOfConsecutive1s = 0;
            int max1StreakAux = 0;

            for (int i = 0; i < _binaryString.Length; i++)
            {
                if (_binaryString[i] == '1')
                {
                    max1StreakAux++;
                    if (max1StreakAux > maxNumberOfConsecutive1s)
                    {
                        maxNumberOfConsecutive1s = max1StreakAux;
                    }
                }
                else
                {
                    max1StreakAux = 0;
                }
            }

            return maxNumberOfConsecutive1s;
        }

        private static string Int2BinaryString(int _n)
        {
            string ret = string.Empty;
            Stack<int> binaryStack = new Stack<int>();

            while (_n > 0)
            {
                var remainder = _n % 2;
                _n /= 2;
                binaryStack.Push(remainder);
            }

            while (binaryStack.Count > 0)
            {
                ret += binaryStack.Pop();
            }

            return ret;
        }
    }
}
