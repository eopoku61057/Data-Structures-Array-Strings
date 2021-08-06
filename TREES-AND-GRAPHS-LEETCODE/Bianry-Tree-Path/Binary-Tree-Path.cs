public class Solution
{
    IList<string> data = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        recur(root, "");
        return data;
    }
    private void recur(TreeNode root, string str)
    {
        if (root == null) return;

        if(root.left == null && root.right == null)
        {
            str += root.val.ToString();
            data.Add(str);
        }
        else
        {
            str += root.val.ToString() + "->";
        }
        recur(root, str);
        recur(root, str);
    }
}