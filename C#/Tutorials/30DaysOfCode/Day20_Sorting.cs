using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-sorting
    /// </summary>
    class Day20_Sorting
    {
        public static void Main()
        {
            // Reading test case
            Convert.ToInt32(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            // Sorting.
            var numberOfSwaps = bubbleSort(a);

            // Printing result.
            Console.WriteLine(string.Format("Array is sorted in {0} swaps.", numberOfSwaps));
            Console.WriteLine(string.Format("First Element: {0}", a[0]));
            Console.WriteLine(string.Format("Last Element: {0}", a[a.Length - 1]));
        }

        private static int bubbleSort(int[] a)
        {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;
            bool hasSwapped = true;

            for (int i = 0; i < a.Length; i++)
            {
                hasSwapped = false;

                for (int j = 0; j < a.Length - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swap(a, j, j + 1);

                        // Swap happened, therefore the number of swaps increase as well as the
                        // control variable that states whether any swap happened during the current
                        // array traversal.
                        numberOfSwaps++;
                        hasSwapped = true;
                    }
                }

                // If no swap was necessary during the current array traversal, then the array is sorted.
                if (hasSwapped == false)
                {
                    break;
                }
            }

            return numberOfSwaps;
        }

        private static void swap(int[] a, int left, int right)
        {
            var aux = a[left];
            a[left] = a[right];
            a[right] = aux;
        }
    }
}
