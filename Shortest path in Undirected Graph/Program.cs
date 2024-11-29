using Shortest_path_in_Undirected_Graph;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.ShortestPath([[0, 1], [0, 3], [3, 4], [4, 5], [5, 6], [1, 2], [2, 6], [6, 7], [7, 8], [6, 8]], 9, 10, 0)));
Console.WriteLine(string.Join(", ", solution.ShortestPath([[1, 3], [3, 0]], 4, 2, 3)));
