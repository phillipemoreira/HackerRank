using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-interfaces
    /// </summary>
    class Day19_Interfaces
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            AdvancedArithmetic myCalculator = new InterfaceCalculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine(("I implemented: AdvancedArithmetic\n" + sum));
        }
    }

    class InterfaceCalculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if ( n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
}
