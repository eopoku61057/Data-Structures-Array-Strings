using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    /*  Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the 
    length of the longest path between any two nodes in a tree. This path may or may not pass through the root.*/
    public class SortedZeros
    {
        // time complexity: 0(N)
        // Space complexity: 0(N)
        public int ans;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            ans = 1;
            depth(root);
            return ans - 1;
        }

        private int depth(TreeNode root)
        {
            if (root == null) return 0;
            int L = depth(root.left);
            int R = depth(root.right);
            ans = Math.Max(ans, L + R + 1);
            return Math.Max(L, R) + 1;
        }
    }
}
