// this will show you how to delete a BST tree when you have a given key

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

            public void DeleteBST(int key)
            {
                root = DeleteFromBST(root, key);
            }

            private Node DeleteFromBST(Node root, int key)
            {
                // Base Case. If the tree is empty
                if (root == null) return root;

                // Otherwise recur down the tree
                if ( key < root.key)
                {
                    root.left = DeleteFromBST(root.left, key);
                }
                else if (key > root.key)
                {
                    root.right = DeleteFromBST(root.right, key);
                }

                // if key is same as root's key, then this is the node to be deleted
                else
                {
                    // node with only one child or no child 
                    if (root.left == null)
                    {
                        return root.right;
                    }
                    else if (root.right == null)
                    {
                        return root.right;
                    }

                    // node with two children: get the inorder successor(smallest in the right subtree)
                    root.key = minValue(root.right);

                    // Delete the inOrder successor
                    root.right = DeleteFromBST(root.right, root.key);
                }

                return root;
            }

            private int minValue(Node right)
            {
                int minv = root.key;
                while(root.left != null)
                {
                    minv = root.left.key;
                    root = root.left;
                }
                return minv;
            }
        }
    }
}
