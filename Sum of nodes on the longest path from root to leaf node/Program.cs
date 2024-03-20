using Sum_of_nodes_on_the_longest_path_from_root_to_leaf_node;

Node root1 = new(4, new(2, new(7), new(1, new(6))), new(5, new(2), new(3)));
Solution solution = new();
Console.WriteLine(solution.SumOfLongRootToLeafPath(root1));