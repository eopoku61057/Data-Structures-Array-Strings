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

        // Time complexity: 0(N)
        // Space complexity: 0(D)
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.offer(root);
            List<int> rightside = new List<int>();

            while(queue.Count > 0)
            {
                int levelLength = queue.Count();

                for (int i = 0; i < levelLength; i++)
                {
                    TreeNode node = queue.Peek();
                    // if it's the rightmost element
                    if (i == levelLength - 1)
                    {
                        rightside.Add(node.val);
                    }

                    // add child nodes in the queue
                    if (node.left != null)
                    {
                        queue.offer(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.offer(node.right);
                    }
                }
            }

            return rightside;
        }
    }
}
