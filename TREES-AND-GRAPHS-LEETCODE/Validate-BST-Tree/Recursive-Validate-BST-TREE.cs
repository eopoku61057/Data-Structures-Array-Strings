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
        // Time Complexity: 0(N) 
        // Space Complexity: 0(N)
        public Boolean helper(TreeNode node)
        {
            if (node == null) { return true; }

            int val = node.val;
            if (node.left != null && val <= node.left.val) return false;
            if (node.right != null && val >= node.right.val) return false;

            if (!helper(node.right)) return false;
            if (!helper(node.left)) return false;

            return true;
        }
        public bool IsValidBST(TreeNode root)
        {
            return helper(root);
        }
    }
}
