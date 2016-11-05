using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-operators
    /// </summary>
    class Day2_Operators
    {
        public static void Main(String[] args)
        {
            // Reading from Console
            double mealCost = Convert.ToDouble(Console.ReadLine());
            double tipPercent = Convert.ToDouble(Console.ReadLine());
            double taxPercent = Convert.ToDouble(Console.ReadLine());

            // Calculating the result.
            double result = mealCost + (mealCost * (tipPercent / 100)) + (mealCost * (taxPercent / 100));

            // Printing it rounded.
            Console.WriteLine("{0:N0}","The total meal cost is " + Math.Round(result) + " dollars.");
        }
    }
}


