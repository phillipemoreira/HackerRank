using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-regex-patterns
    /// </summary>
    class Day28_RegexPatterns
    {
        public static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            List<string> firstNameList = new List<string>();
            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];

                if (IsGmail(emailID))
                {
                    firstNameList.Add(firstName);
                }
            }

            var ordered = firstNameList.OrderBy(x => x);

            foreach (var name in ordered)
            {
                Console.WriteLine(name);
            }
        }

        private static bool IsGmail(string emailId)
        {
            return new Regex(@"^.{1,50}@gmail.com$").IsMatch(emailId);
        }
    }
}
