using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int key;
            public Node left;
            public Node right;

            public Node(int item)
            {
                key = item;
                left = null;
                right = null;
            }
        }

        public class BinaryTree
        {
            // root of the binary tree
            public Node root;

            // constructors
            public BinaryTree(int key)
            {
                root = new Node(key);
            }

            public BinaryTree()
            {
                root = null;
            }

        }

    public class Program 
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            // create a root 
            tree.root = new Node(1);

            /* this is the tree after the above statement 
                1
               /  \
             null  null  */

            tree.root.left = new Node(2);
            tree.root.right = new Node(3);

            /* 2 and 3 become left and right children of 1 
            1 
            / \ 
          2     3 
         / \   / \ 
    null null null null */

            tree.root.left.left = new Node(4);

            /* 4 becomes left child of 2 
                        1 
                    /     \ 
                2         3 
                / \     / \ 
              4 null null null 
            / \ 
            null null 
            */
        }

    }

    }


}
