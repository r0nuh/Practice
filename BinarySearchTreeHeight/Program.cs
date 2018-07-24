using System;

namespace BinarySearchTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Node root = null;
            int[] items = { 20, 50, 35, 44, 9, 15, 62, 11, 13 };
            //int[] items = { 20, 10, 15, 14, 9, 5, 2, 1, 3 };

            foreach (var data in items)
            {
                root = s.Insert(root, data);
            }
            int height = s.GetHeight(root);
            Console.WriteLine(height);

            Console.Read();
        }
    }
}
