using System;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-linked-list
    /// </summary>
    class Day15_LinkedList
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            else
            {
                var iterator = head;
                while (iterator.next != null)
                {
                    iterator = iterator.next;
                }

                iterator.next = new Node(data);
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static void Main()
        {
            Node head = null;
            var T = Convert.ToInt32(Console.ReadLine());
            while (T-- > 0)
            {
                var data = Convert.ToInt32(Console.ReadLine());
                head = insert(head, data);
            }

            display(head);
        }
    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
