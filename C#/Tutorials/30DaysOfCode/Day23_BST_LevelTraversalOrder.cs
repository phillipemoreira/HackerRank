using System;
using System.Collections.Generic;

namespace HackerRank.BST
{
    /// <summary>
    /// Problem link:https://www.hackerrank.com/challenges/30-binary-trees
    /// </summary>
    public class Day23_BST_LevelTraversalOrder
    {
        static void levelOrder(Node root)
        {
            Queue<Node> bstQueue = new Queue<Node>();

            bstQueue.Enqueue(root);
            while (bstQueue.Count > 0)
            {
                Node cur = bstQueue.Dequeue();
                Console.Write(cur.data + " ");

                if (cur.left != null)
                {
                    bstQueue.Enqueue(cur.left);
                }

                if (cur.right != null)
                {
                    bstQueue.Enqueue(cur.right);
                }
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public static void Main()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            levelOrder(root);
        }
    }
}
