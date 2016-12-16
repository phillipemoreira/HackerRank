using System;
using System.Collections.Generic;

namespace HackerRank
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-linked-list-deletion
    /// Class Node is defined under file: Day15_LinkedLists.
    /// </summary>
    class Day24_MoreLinkedLists
    {
        public static void Main()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }

        public static Node removeDuplicates(Node head)
        {
            if (head == null) return null;

            List<int> listValues = new List<int>();
            listValues.Add(head.data);

            Node left = head;
            Node right = head.next;
            
            while (right != null)
            {
                while (right != null && listValues.Contains(right.data))
                {
                    right = right.next;
                }

                left.next = right;

                if (right != null)
                {
                    listValues.Add(right.data);
                    left = right;
                }
            }

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);

            if (head == null)
            {
                head = p;
            }
            else if (head.next == null)
            {
                head.next = p;
            }
            else
            {
                Node Start = head;
                while (Start.next != null)
                {
                    Start = Start.next;
                }
                Start.next = p;
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
    }
}
