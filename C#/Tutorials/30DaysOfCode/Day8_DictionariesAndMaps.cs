using System;
using System.Collections.Generic;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-dictionaries-and-maps
    /// </summary>
    class Day8_DictionariesAndMaps
    {
        public static void Main()
        {
            // Creating the phone book.
            Dictionary<String, string> phoneBook = new Dictionary<string, string>();

            // Number of entries to the phone book.
            int N = Convert.ToInt32(Console.ReadLine());

            // Adding the entries to the phone book.
            for (int n = 0; n < N; n++)
            {
                string[] entry = Console.ReadLine().Split(' ');
                phoneBook.Add(entry[0], entry[1]);
            }

            // Addressing the queries
            string query = Console.ReadLine();
            while (query != string.Empty && query != null)
            {
                if (phoneBook.ContainsKey(query))
                {
                    string phoneNumber;
                    phoneBook.TryGetValue(query, out phoneNumber);
                    Console.WriteLine(string.Format("{0}={1}", query, phoneNumber));
                }
                else
                {
                    Console.WriteLine("Not found");
                }

                query = Console.ReadLine();
            }
        }
    }
}
