using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-more-exceptions
    /// </summary>
    class Day17_MoreExceptions
    {
        public static void Main()
        {
            var T = Convert.ToInt32(Console.ReadLine());
            while (T-- > 0)
            {
                var nums = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
                try
                {
                    Calculator myCalculator = new Calculator();
                    var ans = myCalculator.power(nums[0], nums[1]);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    class Calculator
    {
        public int power(int a, int b)
        {
            // Every number powered to 0 equals 1.
            if (b == 0)
            {
                return 1;
            }
            // 0 powered to any number greater than 0 equals 0.
            else if (a == 0)
            {
                return 0;
            }
            else if (a >= 0 && b > 0 )
            {
                var result = a;
                for (int i = 1; i < b; i++)
                {
                    result = result * a;
                }

                return result;
            }

            throw new Exception(string.Format("n and p should be non-negative", a, b));
        }
    }
}
