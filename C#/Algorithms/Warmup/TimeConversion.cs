using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/time-conversion
    /// </summary>
    class TimeConversion
    {
        public static void Main(String[] args)
        {
            string time = Console.ReadLine();

            var _24Format = ConvertTo24Format(time);

            Console.WriteLine(_24Format);
        }

        static string ConvertTo24Format(string _12Format)
        {
            var hour = Convert.ToInt32(_12Format.Substring(0, 2));
            _12Format = _12Format.Remove(0, 2);

            if (_12Format.Contains("PM"))
            {
                if (hour != 12)
                {
                    hour += 12;
                }
            }
            else if (hour == 12)
            {
                hour = 00;
            }

            _12Format = _12Format.Remove(6, 2);

            return string.Format("{0:00}{1}", hour, _12Format);
        }
    }
}
