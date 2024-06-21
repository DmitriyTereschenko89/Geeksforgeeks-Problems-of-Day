using Kth_common_ancestor_in_BST;

Node root1 = new(10, new(50), new(40, new(20), new(30)));
Node root2 = new(80, new(40, new(70)), new(30, new(60), new(70)));
Solution solution = new();
Console.WriteLine(solution.KthCommonAncestor(root1, 2, 20, 30));
Console.WriteLine(solution.KthCommonAncestor(root2, 2, 70, 60));