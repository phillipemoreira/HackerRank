using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UUX.logic
{
    /// <summary>
    /// UUX Development test made by Phillipe Moreira at 2016/11/27
    /// </summary>
    class Solution
    {
        public static void Main()
        {
            var numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int testCase = 0; testCase < numberOfTestCases; testCase++)
            {
                try
                {
                    var input = Console.ReadLine();
                    if (solution(input) == 1)
                    {
                        Console.WriteLine(string.Format("String: '{0}' is an anagram of the palindrome '{1}'.", input, "foo"));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("String '{0}' is not an anagram of any palindrome.", input));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Something wrong happened: {0}", e.Message));
                }
            }

            Console.ReadLine();
        }

        public static int solution(string s)
        {
            // Approach:
            // 1 - get all combinations that can be obtained with the letters of string s
            // 2 - Verify whether any of the combinations is a palindrome, return 1 if any of them are.
            // 3 - return 0 if none palindrome_anagram match is found.

            if (s == string.Empty) throw new Exception("The string s must not be an empty string.");

            var combinations = GetCombinations(s);

            var t = combinations.Where(i => i == "test");

            return 0;
        }

        private static List<string> GetCombinations(string s)
        {
            return new List<string>() {"test", "test1" };
        }

        private static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length -1; j > s.Length / 2; j++)
                {
                    if (s[i] != s[j]) return false;
                }
            }

            return true;
        }
    }
}
