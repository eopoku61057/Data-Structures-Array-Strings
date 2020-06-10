using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public TreeNode deserialize(string data)
        {
            Queue<string> queue = new Queue<string>();
            string[] d = data.Split(",");
            for (int i = 0; i < d.Length; i++)
            {
                queue.Enqueue(d[i]);
            }

            return BuildTree(queue);
        }

        private TreeNode BuildTree(Queue<string> queue)
        {
            string first = queue.Dequeue();
            if (first.Equals("#")) return null;
            TreeNode root = new TreeNode(int.Parse(first));
            root.left = BuildTree(queue);
            root.right = BuildTree(queue);

            return root;
        }

        public string serialize(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            BuildString(root, sb);
            return sb.ToString();
        }

        private void BuildString(TreeNode root, StringBuilder sb)
        {
            if(root == null)
            {
                sb.Append("#,");
                return;
            }

            sb.Append(root.val);
            sb.Append(",");
            BuildString(root.left, sb);
            BuildString(root.right, sb);
        }

        static void Main(string[] args)
        {
            SortedZeros sb = new SortedZeros();
            TreeNode tre = new TreeNode(1);
            tre.left = new TreeNode(2);
            tre.right = new TreeNode(3);
            tre.right.left = new TreeNode(4);
            tre.right.right = new TreeNode(5);

            string st = "1,2,3,null,null,4,5";

            string mm = sb.serialize(tre);

            TreeNode da = sb.deserialize(mm);
            Console.WriteLine(mm);
           
        }
    }
}
