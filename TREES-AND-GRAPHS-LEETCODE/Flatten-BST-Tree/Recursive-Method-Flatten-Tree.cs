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
        public TreeNode FlattenTree(TreeNode root)
        {
            // Time complexity: 0(n)
            // Space complexity: 0(n)
            // Handle the null scenario
            if(root == null)
            {
                return null;
            }

            // For a leaf node, we simply return the node as is
            if (root.left == null && root.right == null)
            {
                return root;
            }

            // Recursively flatten the left subtree
            TreeNode leftTail = this.FlattenTree(root.left);

            // Recursively flatten the right subtree
            TreeNode rightTail = this.FlattenTree(root.right);

            //if there was a left subtree, we shuffle the connections around so that there is nothing on 
            // the left side anymore.
            if(leftTail != null)
            {
                leftTail.right = root.right;
                root.right = root.left;
                root.left = null;
            }

            // We need to return the "rightmost" node after we are done wiring the new connections
            return rightTail == null ? leftTail : rightTail;

        }

        public void flatten(TreeNode root)
        {
            this.FlattenTree(root);
        }
    }
}
