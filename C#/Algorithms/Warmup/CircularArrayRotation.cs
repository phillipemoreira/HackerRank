using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/circular-array-rotation 
    /// This is the fast implementation.
    /// </summary>
    class CircularArrayRotation
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var position = getPositionAfterRotaion(a, k);

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                var curPos = position;

                for (int j = 0; j < m; j++)
                {
                    if (curPos < a.Length - 1) curPos++;
                    else curPos = 0;
                }
                Console.WriteLine(a[curPos]);
            }
        }

        private static int getPositionAfterRotaion(int[] array, int times)
        {
            int pos = 0;
            for (int i = 0; i < times; i++)
            {
                if (pos > 0) pos--;
                else pos = array.Length - 1;
            }

            return pos;
        }
    }
}
