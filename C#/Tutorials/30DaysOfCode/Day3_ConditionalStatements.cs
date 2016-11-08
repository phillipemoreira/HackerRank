using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-conditional-statements
    /// </summary>
    class Day3_ConditionalStatements
    {
        public static void Main(String[] args)
        {
            // Reading from console
            int N = Convert.ToInt32(Console.ReadLine());

            // Printing whether the number is weird or not based on the return of the funcion.
            Console.WriteLine(isNumberWeird(N) ? "Weird" : "Not Weird");
        }

        private static bool isNumberWeird(int _number)
        {
            if (isNumberOdd(_number))
            {
                return true;
            }
            else if (_number >= 2 && _number <= 5)
            {
                return false;
            }
            else if (_number >= 6 && _number <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool isNumberOdd(int _number)
        {
            return _number % 2 != 0;
        }
    }
}
