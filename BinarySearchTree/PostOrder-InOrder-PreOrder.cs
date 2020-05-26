// this will show you how we print postOrder, InOrder and PreOrder from BST

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

            public void PrintPostOrder(Node node)
            {
                // Given a binary tree, print its nodes according to the "bottom-up" postorder traversal
                if (node == null)
                {
                    return;
                }

                // first recur on left subtree
                PrintPostOrder(node.left);

                // then recur on right subtree
                PrintPostOrder(node.right);

                Console.Write(node.key + " ");
            }

            public void PrintInOrder(Node node)
            {
                /* Given a binary tree, print its nodes in inorder*/
                if (node == null)
                {
                    return;
                }

                // first recur on the left subtree
                PrintInOrder(node.left);

                // then print the data of node
                Console.Write(node.key + " ");

                // now recur on the right child
                PrintInOrder(node.right);
            }

            public void PrintPreOrder(Node node)
            {
                if (node == null)
                {
                    return;
                }

                // then print the data of node
                Console.Write(node.key + " ");

                // first recur on the left
                PrintPreOrder(node.left);

                // now recur on the right
                PrintPreOrder(node.right);
            }

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

            tree.PrintPostOrder(tree.root);
            Console.WriteLine();

            tree.PrintInOrder(tree.root);
            Console.WriteLine();

            tree.PrintPreOrder(tree.root);
        }
        }
    }
}
