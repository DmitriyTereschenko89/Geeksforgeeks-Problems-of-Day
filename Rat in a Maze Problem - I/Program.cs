using Rat_in_a_Maze_Problem___I;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.FindPath([[1, 0, 0, 0],
                [1, 1, 0, 1],
                [1, 1, 0, 0],
                [0, 1, 1, 1]])));
Console.WriteLine(string.Join(", ", solution.FindPath([[1, 0],
                [1, 0]])));
