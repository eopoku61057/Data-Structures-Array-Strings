/*Given a binary tree rooted at root, the depth of each node is the shortest distance to the root.

A node is deepest if it has the largest depth possible among any node in the entire tree.

The subtree of a node is that node, plus the set of all descendants of that node.

Return the node with the largest depth such that it contains all the deepest nodes in its subtree. */

    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int h = 0;
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        if (root == null || root.left == null && root.right == null) return root;

        h = GetHeight(root);

        return FindLCA(root, 1);
    }

    private int GetHeight(TreeNode root)
    {
        if (root == null) return 0;

        int l = GetHeight(root.left);
        int r = GetHeight(root.right);

        return l >= r ? l + 1 : r + 1;
    }

    private TreeNode FindLCA(TreeNode root, int i)
    {
        if(i == h)
        {
            return root;
        }

        TreeNode l = null, r = null;

        if(root.left != null)
        {
            l = FindLCA(root.left, i + 1);
        }

        if(root.right != null)
        {
            r = FindLCA(root.right, i + 1);
        }

        if(l != null && r != null)
        {
            return root;
        }
        else if ( l != null)
        {
            return l;
        }
        else
            return r;
    }
}