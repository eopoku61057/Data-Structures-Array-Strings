/*
    Given a binary tree, return the vertical order traversal of its nodes' values. (ie, from top to bottom, column by column).

    If two nodes are in the same row and column, the order should be from left to right.
 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class NumMatrix
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            IList<IList<int>> output = new List<IList<int>>();
            if (root == null)
            {
                return output;
            }

            var columTable = new Dictionary<int, List<int>>();
            var queue = new Queue<KeyValuePair<TreeNode, int>>();
            int column = 0;
            queue.Enqueue(new KeyValuePair<TreeNode, int>(root, column));

            while(queue.Count > 0)
            {
                KeyValuePair<TreeNode, int> p = queue.Peek();
                root = p.Key;
                column = p.Value;

                if (root != null)
                {
                    if (!columTable.ContainsKey(column))
                    {
                        columTable.Add(column, new List<int>());
                    }
                    columTable.GetValueOrDefault(column).Add(root.val);

                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.left, column - 1));
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.right, column + 1));
                }
            }

            var SortedKeys = new List<int>(columTable.Keys);
            List<int> sort = (List<int>)SortedKeys.OrderBy(x => x);
            foreach (var c in sort)
            {
                output.Add(columTable.GetValueOrDefault(c));
            }

            return output;
        }
    }
}
