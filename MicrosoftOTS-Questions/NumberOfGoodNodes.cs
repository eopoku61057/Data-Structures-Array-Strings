/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
//1448. Count Good Nodes in Binary Tree
/*Given a binary tree root, a node X in the tree is named good if in the 
 * path from root to X there are no nodes with a value greater than X.

Return the number of good nodes in the binary tree.*/
class Solution
{
    private int numberOfGoodNodes;
    public int goodNodes(TreeNode root)
    {
        int value = 0;
        dfs(root, value);
        return numberOfGoodNodes;
    }
    private void dfs(TreeNode root, int value)
    {
        if (value <= root.val)
            numberOfGoodNodes++;

        if (root.right != null)
            dfs(root.right, root.val);

        if (root.left != null)
            dfs(root.left, root.val);
    }
}