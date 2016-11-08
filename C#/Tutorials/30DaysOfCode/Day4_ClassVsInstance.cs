using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-class-vs-instance
    /// </summary>
    class Day4_ClassVsInstance
    {
        public static void Main(String[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();

                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }

    class Person
    {
        public int age;

        public Person(int _initialAge)
        {
            if (_initialAge >= 0 )
            {
                age = _initialAge;
            }
            else
            {
                age = 0;

                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void yearPasses()
        {
            age++;
        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }
    }
}
