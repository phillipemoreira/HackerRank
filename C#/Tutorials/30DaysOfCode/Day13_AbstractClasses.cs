using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-abstract-classes
    /// </summary>
    class Day13_AbstractClasses
    {
        public static void Main()
        {
            String tittle = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());

            Book new_novel = new MyBook(tittle, author, price);
            new_novel.display();
        }
    }
 
    abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }

        public abstract void display();
    }

    class MyBook : Book
    {
        int price;

        public MyBook(string t, string a, int p) : base (t, a)
        {
            price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
