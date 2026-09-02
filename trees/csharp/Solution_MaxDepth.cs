public class Solution_MaxDepth
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
            return 0;
        var left = MaxDepth(root.left) + 1;
        var right = MaxDepth(root.right) + 1;

        var maxDepth = int.Max(left, right);

        return maxDepth;
    }
}
