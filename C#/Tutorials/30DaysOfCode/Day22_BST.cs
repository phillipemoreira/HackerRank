using System;

namespace HackerRank.BST
{
    /// <summary>
    /// Problem link: https://www.hackerrank.com/challenges/30-binary-search-trees
    /// </summary>
    class Day22_BST
    {
        public static void Main()
        {
            Node root = null;
            int T = Convert.ToInt32(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        private static int getHeight(Node root)
        {
            if(root == null)
            {
                return -1;
            }

            var leftHeight = getHeight(root.left);
            var rightHeight = getHeight(root.right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        private static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new BST.Node(data);
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
    }

    class Node
    {
        public Node left, right;
        public int data;
        public Node (int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
