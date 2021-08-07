using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            // create root
            tree.root = new TreeNode(3);
            tree.root.Left = new TreeNode(9);
            tree.root.Right = new TreeNode(8);
            tree.root.Left.Left = new TreeNode(4);
            tree.root.Left.Right = new TreeNode(0);
            tree.root.Left.Right.Left = new TreeNode(5);
            tree.root.Right.Right = new TreeNode(7);
            tree.root.Right.Left = new TreeNode(1);
            tree.root.Right.Left.Right = new TreeNode(2);

            IList<IList<int>> ret = VerticalOrder(tree.root);

        }

        /// <summary>
        /// Actual method to concerntrate for VerticalOrder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private static IList<IList<int>> VerticalOrder(TreeNode root)
        {
            IList<IList<int>> outputList = new List<IList<int>>();
            if (root == null) return outputList;

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            Queue<KeyValuePair<TreeNode, int>> queue = new Queue<KeyValuePair<TreeNode, int>>();
            int column = 0;
            queue.Enqueue(new KeyValuePair<TreeNode, int>(root, column));

            while (queue.Any())
            {
                var curr = queue.Dequeue();
                root = curr.Key;
                column = curr.Value;

                if (root != null)
                {
                    if (!dict.ContainsKey(column))
                    {
                        dict.Add(column, new List<int>(root.val));
                    }
                    dict.GetValueOrDefault(column).Add(root.val);

                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.Left, column - 1));
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.Right, column + 1));
                }
            }

            var sorted = new List<int>(dict.Keys);
            var sort = sorted.OrderBy(x => x);
            foreach (var c in sort)
            {
                outputList.Add(dict.GetValueOrDefault(c));
            }


            return outputList;
        }
    }
}

/*------------------------------------------------------------------------------*/
// create a new class for this if you want to test 
namespace ConsoleApp1
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int _val = 0, TreeNode left = null, TreeNode right = null)
        {
            val = _val;
            Left = left;
            Right = right;
        }
    }

    public class BinaryTree
    {
        public TreeNode root { get; set; }
        public BinaryTree(int key)
        {
            root = new TreeNode(key);
        }

        public BinaryTree()
        {
            root = null;
        }
    }
}

