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
       // Iterative approach
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count() > 0)
            {
                TreeNode current = queue.Peek();
                TreeNode tmp = current.left;
                current.left = current.right;
                current.right = tmp;

                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }
            return root;
        }
    }
}
