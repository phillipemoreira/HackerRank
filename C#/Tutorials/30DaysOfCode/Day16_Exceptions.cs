using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-exceptions-string-to-integer
    /// </summary>
    class Day16_Exceptions
    {
        public static void Main()
        {
            string S = Console.ReadLine();

            try
            {
                var I = Convert.ToInt32(S);
                Console.WriteLine(I);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
