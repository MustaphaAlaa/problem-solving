using System.Xml;

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
public class Solution_LevelOrder
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        

        Queue<TreeNode> queue = new();
        queue.Append(root);
        while (queue.Count >= 1)
        {
            var level = new List<int>();
            var queueCount = queue.Count;
            foreach (var i in Enumerable.Range(0, queueCount))
            {
                var node = queue.Dequeue();
                if (node is not null)
                {
                    level.Add(node.val);
                    if (node.left is not null)
                        queue.Append(node.left);
                    if (node.right is not null)
                        queue.Append(node.right);
                }
            }
            result.Add(level);
        }
        return result;
    }
}
