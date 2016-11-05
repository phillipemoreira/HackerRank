using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-data-types
    /// </summary>
    class Day1_DataTypes
    {
        public static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int inputInteger;
            double inputDouble;
            string inputString;

            // Read and save an integer, double, and String to your variables.
            inputInteger = Convert.ToInt32(Console.ReadLine());
            inputDouble = Convert.ToDouble(Console.ReadLine());
            inputString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + inputInteger);

            // Print the sum of the double variables on a new line.
            double resDouble = d + inputDouble;
            Console.WriteLine(string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:N1}", resDouble));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + inputString);
        }
    }
}
