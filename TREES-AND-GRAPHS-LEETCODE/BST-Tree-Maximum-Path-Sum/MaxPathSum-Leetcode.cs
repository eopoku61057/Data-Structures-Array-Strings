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
        public int max_sum = int.MinValue;

        public int MaxPathSum(TreeNode root)
        {
            max_gain(root);
            return max_sum;
        }

        private int max_gain(TreeNode root)
        {
            // time complexity: 0(N)
            // Space complexity: 0(logN)
            // base case
            if (root == null)
            {
                return 0;
            }

            // max sum on the left and right sub-trees of node
            int left_gain = Math.Max(max_gain(root.left), 0);
            int right_gain = Math.Max(max_gain(root.right), 0);

            // the price to start a new path where 'node' is a highest node
            int price_newpath = root.val + left_gain + right_gain;

            // update max_sum if it's better to start a new path
            max_sum = Math.Max(max_sum, price_newpath);

            // for recursion return the max gain if continue the same path
            return root.val + Math.Max(left_gain, right_gain);
        }
    }
}
