public class Solution_IsBalanced_
{
   public bool IsBalanced(TreeNode root)
    {
        return DFS(root) != -1;
    }

    public int DFS(TreeNode root)
    {
        if (root is null)
            return 0;

        int left = DFS(root.left);
        
        if(left == -1)
        return -1;

        int right = DFS(root.right);
        
        if(right == -1)
            return -1;

        if(Math.Abs(left - right) > 1 )
            return -1;

        return 1 + Math.Max(left, right);
    }
}
