TreeNode root = new(2);
root.left = new(1);
root.right = new(3);


Solution_IsValidBST ps = new();


var res = ps.IsValidBST(root);

System.Console.WriteLine(res);