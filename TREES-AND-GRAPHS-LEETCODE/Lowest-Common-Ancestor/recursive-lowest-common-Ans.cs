using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    {
        public TreeNode ans;

        public Boolean recurseTree(TreeNode currentNode, TreeNode p, TreeNode q)
        {
            //Time Complexity: 0(N)
            //Space complexity: 0(N)
            // if reach the end of a branch, return false
            if (currentNode == null)
            {
                return false;
            }

            // left recursion. If left recursion returns true, set left = 1 else 0
            int left = this.recurseTree(currentNode.left, p, q) ? 1 : 0;

            // right recursion
            int right = this.recurseTree(currentNode.right, p, q) ? 1 : 0;

            // If the current node is one of p or q
            int mid = (currentNode == p || currentNode == q) ? 1 : 0;

            // If any two of the flags left, right or mid become True
            if (mid + left + right >= 2)
            {
                this.ans = currentNode;
            }

            // Return true if any one of the three bool values is True.
            return (mid + left + right > 0);

        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            // traverse the tree
            this.recurseTree(root, p, q);
            return this.ans;
        }
    }
}
