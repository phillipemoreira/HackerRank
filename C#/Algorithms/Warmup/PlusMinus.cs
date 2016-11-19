using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/plus-minus
    /// </summary>
    class PlusMinus
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            var positive = 0;
            var negative = 0;
            var zero = 0;

            foreach (var num in arr)
            {
                if (num > 0) positive++;
                else if (num < 0) negative++;
                else zero++;
            }

            float positiveFraction = (float)positive / (float)n;
            var positiveFormatted = string.Format("{0:0.000000}", positiveFraction);
            Console.WriteLine(positiveFormatted);

            float negativeFraction = (float)negative / (float)n;
            var negativeFormatted = string.Format("{0:0.000000}", negativeFraction);
            Console.WriteLine(negativeFormatted);

            float zeroFraction = (float)zero / (float)n;
            var zeroFormatted = string.Format("{0:0.000000}", zeroFraction);
            Console.WriteLine(zeroFormatted);
        }
    }
}
