using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{/*
    Given a Binary Search Tree and a target number,
    return true if there exist two elements in the BST such that their sum is equal to the given target.
*/
    class Solution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        private HashSet<int> map = new HashSet<int>();
        private bool output = false;
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null)
            {
                return false;
            }
            
            
            if (map.Count > 0 )
            {
                int data = k - root.val;
                if (map.Contains(data))
                {
                    output = true;
                    return output;
                }
            }
            map.Add(root.val);

            FindTarget(root.left, k);
            FindTarget(root.right, k);

            return output;
        }

        static void Main(string[] args)
        {
            Solution sb = new Solution();

            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);

            root.right = new TreeNode(6);
            root.right.right = new TreeNode(7);

            int target = 9;
            bool getTarget = sb.FindTarget(root, target);

        }
    }
}
