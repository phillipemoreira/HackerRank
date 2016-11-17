using System;
using System.Linq;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-scope
    /// </summary>
    class Day14_Scoce
    {
        public static void Main(String[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }

        class Difference
        {
            private int[] elements;
            public int maximumDifference;

            //Add your code here

            public Difference(int[] elements)
            {
                this.elements = elements;
            }

            public void computeDifference()
            {
                var smallest = elements.Min();
                var biggest = elements.Max();

                maximumDifference = biggest - smallest;
            }
        }
    }
}
