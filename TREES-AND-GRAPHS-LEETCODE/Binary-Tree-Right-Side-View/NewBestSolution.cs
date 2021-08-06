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
            var dict = new Dictionary<int, int>();

            DFS(root, 0, dict);
            return dict.Values.ToList();
        }

        private void DFS(TreeNode node, int level, Dictionary<int, int>() dict)
        {
            if (node == null) return;

            if(!dict.ContainsKey(level))
            {
                dict.Add(level, node.val);
            }

            DFS(node.right, level + 1, dict);
            DFS(node.left, level + 1, dict);
        }
    }
}
