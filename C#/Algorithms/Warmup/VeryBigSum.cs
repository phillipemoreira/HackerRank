using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/a-very-big-sum
    /// </summary>
    public class VeryBigSum
    {
        public static void Main()
        {
            Console.ReadLine();
            string[] arr_temp = Console.ReadLine().Split(' ');
            Int64[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

            Int64 sum = 0;
            foreach (var element in arr)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
