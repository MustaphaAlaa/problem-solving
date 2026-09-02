public class Solution_IsBalanced
{
    public bool IsBalanced(TreeNode root)
    {
        if (root is null)
            return true;

        var left = DFS(root.left);
        var right = DFS(root.right);

        if (Math.Abs(left - right) > 1)
            return false;

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int DFS(TreeNode root)
    {
        if (root is null)
            return 0;
        var left = DFS(root.left);
        var right = DFS(root.right);

        return int.Max(left, right) + 1;
    }
}
