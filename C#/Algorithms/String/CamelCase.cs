using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/camelcase
    /// </summary>
    class CamelCase
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int amountOfWords = 1;

            foreach (char letter in input)
            {
                // means that it is not (ASCII) lower case english letter
                // for full table, please check: http://www.asciitable.com/
                if (letter < 97)
                {
                    amountOfWords++;
                }
            }

            Console.WriteLine(amountOfWords);
        }
    }
}
