using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/the-love-letter-mystery
    /// </summary>
    /// <remarks>
    /// The problem says the class name should be named Solution, but here it has the problem name to avoid issue with other problems.
    /// </remarks>
    class LoveLetterMistery
    {
        public static void Main(String[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
        
            // Iterating test cases
            for (int cases = 0; cases < numberOfTestCases; cases ++)
            {
                string inputString = Console.ReadLine();

                int minimumOperations = 0;
                string auxWord = inputString;

                //Iterating half of the string size times
                for (int j = 0; j < auxWord.Length / 2; j ++)
                {
                    //Comparing the borders of the string starting from the outermost to inner.
                    char left = auxWord[j];
                    char right = auxWord[auxWord.Length -1 - j];

                    // If the borders pairs aren't equal, decrease the bigger one until they get equal.
                    while (left != right)
                    {
                        if (left > right)
                        {
                            int aux = left - 1;
                            left = (char)aux;
                        }
                        else
                        {
                            int aux = right - 1;
                            right = (char)aux;
                        }

                        // Everytime a char is changed, the number of operations increase.
                        minimumOperations++;
                    }
                    if (isPalindrome(auxWord)) break;
                }

                Console.WriteLine(minimumOperations);
            }
        }

        private static bool isPalindrome(string _word)
        {
            for (int i = 0; i < _word.Length/2; i ++)
            {
                if (_word[i] != _word[_word.Length -1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
