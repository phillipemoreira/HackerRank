using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-2d-arrays
    /// </summary>
    class Day11_2DArrays
    {
        public static void Main()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            // Given that the values ranges are actually -9 up to 9,
            // The smallest possible sum in case all elements of the hourgalss are -9
            // would be -63, in other worlds: the minimum possible sum.
            int max = -63;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j ++)
                {
                    var sum = GetHourglassSum(arr, j, i);
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }

            Console.WriteLine(max);
        }

        /// <summary>
        /// Returns the sum of the hourglass values.
        /// </summary>
        /// <param name="_array">An array representing the hourglass</param>
        /// <param name="_line">Line position of the first hourglass element</param>
        /// <param name="_column">column postion of the first hourglass element</param>
        /// <returns>The sum of the hourglass elements.</returns>
        private static int GetHourglassSum(int[][] _array, int _line, int _column)
        {
            int sum = 0;

            sum = _array[_line][_column] + _array[_line][_column + 1] + _array[_line][_column + 2];
            sum += _array[_line + 1][_column + 1];
            sum += _array[_line + 2][_column] + _array[_line + 2][_column + 1] + _array[_line + 2][_column + 2];

            return sum;
        }
    }
}
