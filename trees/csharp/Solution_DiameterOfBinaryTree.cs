public class Solution_DiameterOfBinaryTree
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int res = 0;
        DFS(root, ref res);

        return res;
    }

    public int DFS(TreeNode root, ref int res)
    {
        if (root is null)
            return 0;
        var left = DiameterOfBinaryTree(root.left);
        var right = DiameterOfBinaryTree(root.right);

        res = int.Max(res, left + right);

        return int.Max(left, right) + 1;
    }
}
