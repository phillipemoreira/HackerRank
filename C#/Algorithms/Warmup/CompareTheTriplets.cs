using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/compare-the-triplets
    /// </summary>
    class CompareTheTriplets
    {
        public static void Main()
        {
            // Reading the notes and placing them in different variables
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            // Initializing the points variables
            int alicePoints = 0;
            int bobPoints = 0;

            // Comparing and grading each one
            if (a0 > b0)
            {
                alicePoints++;
            }
            else if (a0 < b0)
            {
                bobPoints++;
            }

            if (a1 > b1)
            {
                alicePoints++;
            }
            else if (a1 < b1)
            {
                bobPoints++;
            }

            if (a2 > b2)
            {
                alicePoints++;
            }
            else if (a2 < b2)
            {
                bobPoints++;
            }

            // Printing the result
            Console.WriteLine(alicePoints + " " + bobPoints);
        }
    }
}
