using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeHeight
{
    class Solution
    {
        public int GetHeight (Node root)
        {
            int height = 0;
            int max = 0;
            bool secondTime = false;
            Node current = root;

            while (root.left != null || root.right != null)
            {
                if (current.left != null)
                {
                    current = current.left;
                    ++height;
                }
                else if (current.right != null)
                {
                    current = current.right;
                    ++height;
                }
                else if (root.left != null && !secondTime)
                {
                    current = root.left;
                    secondTime = true;
                    current.left = null;
                    height = 1;
                }
                else if (root.left != null && root.right != null)
                {
                    root.left = null;
                    current = root.right;
                    secondTime = false;
                    height = 1;
                }
                else if (root.left == null && !secondTime)
                {
                    current = root.right;
                    secondTime = true;
                    current.left = null;
                    height = 1;                        
                }
                else
                {
                    root.left = null;
                    root.right = null;  
                }

                max = Math.Max(height, max);
            }           

            return max;
        }

        public Node Insert (Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node current;
                if (data <= root.data)
                {
                    current = Insert(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = Insert(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }
    }
}
