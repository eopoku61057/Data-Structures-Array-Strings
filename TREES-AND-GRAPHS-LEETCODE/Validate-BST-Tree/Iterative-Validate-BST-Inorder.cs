using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    {
        public bool IsValidBST(TreeNode root)
        {
            // Time complexity: 0(N)
            // Space complexity: 0(N)
            Stack<TreeNode> stack = new Stack<TreeNode>();
            double inorder = -double.MaxValue;

            while(stack.Count >= 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();

                // If next element in inorder traversal is smaller than the previous that's not BST
                if (root.val <= inorder) return false;
                inorder = root.val;
                root = root.right;
            }

            return true;
        }
    }
}
