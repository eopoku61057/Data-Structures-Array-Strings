using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    { // Invert a binary tree
       // Time complexity: 0(N)
       // Space complexity: 0(N)
       // recursive approach
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            TreeNode tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
