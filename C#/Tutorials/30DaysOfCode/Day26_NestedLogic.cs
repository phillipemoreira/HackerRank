using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-nested-logic
    /// </summary>
    class Day26_NestedLogic
    {
        public static void Main()
        {
            // INPUT
            var actualReturnedDate = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            var expectedReturnedDate = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            // RESULT
            Console.WriteLine(CalculateFine(expectedReturnedDate, actualReturnedDate));
        }

        private static int CalculateFine(int[] expectedReturnDate, int[] actualReturnDate)
        {
            if (actualReturnDate[2] == expectedReturnDate[2])
            {
                if (actualReturnDate[1] == expectedReturnDate[1])
                {
                    if (actualReturnDate[0] <= expectedReturnDate[0])
                    {
                        return 0;
                    }

                    return 15 * (actualReturnDate[0] - expectedReturnDate[0]);
                }
                else if (actualReturnDate[1] < expectedReturnDate[1])
                {
                    return 0;
                }

                return 500 * (actualReturnDate[1] - expectedReturnDate[1]);
            }
            else if (actualReturnDate[2] < expectedReturnDate[2])
            {
                return 0;
            }

            return 10000;
        }
    }
}
