using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-review-loop
    /// </summary>
    class Day6_Review
    {
        public static void Main(String[] args)
        {
            // Number of test cases.
            int T = Convert.ToInt32(Console.ReadLine());

            // Iterating test cases.
            for (int t = 0; t < T; t ++)
            {
                string S = Console.ReadLine();

                string even = string.Empty;
                string odd = string.Empty;

                // Iterating 2 by 2 the letters of the string.
                for (int j = 0; j < S.Length; j += 2)
                {
                    even += S[j];

                    // If the length of the string is odd, this 
                    // if is false in the last iteration.
                    if (j + 1 < S.Length)
                    {
                        odd += S[j + 1];
                    }
                }

                Console.Write(even);
                Console.Write(" ");
                Console.WriteLine(odd);
            }
        }
    }
}
