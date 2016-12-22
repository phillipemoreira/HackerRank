using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-testing
    /// </summary>
    class Day27_Testing
    {
        public static void Main()
        {
            // Number of Lectures
            Console.WriteLine(5);

            PrintTestCase1();
            PrintTestCase2();
            PrintTestCase3();
            PrintTestCase4();
            PrintTestCase5();
        }

        private static void PrintTestCase1()
        {
            // Number of Students + Threashhold
            PrintNumberOfStudentsAndThreashold(3, 1);

            //Students arrival time
            PrintStudentsArrivalTime(new int[] { -1, 0, 1});
        }

        private static void PrintTestCase2()
        {
            // Number of Students + Threashhold
            PrintNumberOfStudentsAndThreashold(4, 3);

            //Students arrival time
            PrintStudentsArrivalTime(new int[] { 0, -1, 2, 1 });
        }

        private static void PrintTestCase3()
        {
            // Number of Students + Threashhold
            PrintNumberOfStudentsAndThreashold(10, 8);

            //Students arrival time
            PrintStudentsArrivalTime(new int[] { -2, -1, 0, 4, 5, 6, 7, 8, 9, 10});
        }

        private static void PrintTestCase4()
        {
            // Number of Students + Threashhold
            PrintNumberOfStudentsAndThreashold(5, 3);

            //Students arrival time
            PrintStudentsArrivalTime(new int[] { -1, 0, 1, 2, 3 });
        }

        private static void PrintTestCase5()
        {
            // Number of Students + Threashhold
            PrintNumberOfStudentsAndThreashold(6, 1);

            //Students arrival time
            PrintStudentsArrivalTime(new int[] { -1, 0, 1, 2, 3, 4 });
        }

        private static void PrintNumberOfStudentsAndThreashold(int numberOfStudents, int threashold)
        {
            Console.Write(numberOfStudents);
            Console.Write(' ');
            Console.Write(threashold);
            Console.WriteLine();
        }

        private static void PrintStudentsArrivalTime(int[] arrivalTime)
        {
            foreach (var item in arrivalTime)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
