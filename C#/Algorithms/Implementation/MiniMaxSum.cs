using System;

/// <summary>
/// Problem link: https://www.hackerrank.com/challenges/mini-max-sum
/// </summary>
class MiniMaxSum
{
    /// <summary>
    /// N^2 approach, where I use the first loop to choose which element to let out of the sum.
    /// </summary>
    public static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Int64[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int64.Parse);

        Int64 smallestSum = 0;
        Int64 biggestSum = 0;

        // Element i is the one being excluded from the sum
        for (int i = 0; i < array.Length; i++)
        {
            Int64 currentSum = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (j != i)
                {
                    currentSum += array[j];
                }
            }
            if (currentSum < smallestSum || smallestSum == 0) smallestSum = currentSum;
            if (currentSum > biggestSum) biggestSum = currentSum;
        }

        Console.WriteLine(String.Format("{0} {1}", smallestSum, biggestSum));
    }
}