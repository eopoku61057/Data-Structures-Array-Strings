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
        // Space complexity: 0(N)
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            List<int> data = new List<int>();

            if (root.right == null)
            {
                data.Add(root.val);
                return data;
            }

            while(root.right != null)
            {
                data.Add(root.val);
                root = root.right;
            }
            data.Add(root.val);

            return data;
        }

        static void Main(string[] args)
        {
            TreeNode newTree = new TreeNode(10);
            newTree.left = new TreeNode(5);
            newTree.right = new TreeNode(15);
            newTree.right.right = new TreeNode(25);

            SortedZeros d = new SortedZeros();
            IList<int> sum = d.RightSideView(newTree);
            
            foreach(var x in sum)
            {
                Console.Write(x + " ");
            }
        }
    }
}
