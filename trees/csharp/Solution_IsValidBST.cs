using System.Runtime.CompilerServices;

public class Solution_IsValidBST
{
    public bool IsValidBST(TreeNode root)
    {
        if (root is null)
            return true;

        var left = DFS(
            root.left,
            parentRootVal: root.val,
            rootVal: root.val,
            isLeft: true,
            isRight: false,
            RootDirection.left
        );

        if (!left)
            return false;

        var right = DFS(
            root.right,
            parentRootVal: root.val,
            rootVal: root.val,
            isLeft: false,
            isRight: true,
            RootDirection.right
        );

        if (!right)
            return false;

        return left && right;
    }

    enum RootDirection
    {
        left,
        right,
    }

    bool CheckDirection(RootDirection rootDirection, int parentRootVal, int rootVal)
    {
        if (rootDirection is RootDirection.left && parentRootVal <= rootVal)
            return false;
        else if (rootDirection is RootDirection.right && parentRootVal >= rootVal)
            return false;

        return true;
    }

    bool DFS(
        TreeNode node,
        int parentRootVal,
        int rootVal,
        bool isLeft,
        bool isRight,
        RootDirection direction
    )
    {
        if (node is null)
            return true;

        var checkParentRootDirection = CheckDirection(direction, parentRootVal, node.val);

        if (!checkParentRootDirection)
            return false;

        if (isLeft && rootVal <= node.val)
            return false;

        if (isRight && rootVal >= node.val)
            return false;

        var left = DFS(node.left, parentRootVal, node.val, true, false, direction);

        if (!left)
            return false;

        var right = DFS(node.right, parentRootVal, node.val, false, true, direction);

        if (!right)
            return false;

        return left && right;
    }
}
