using Row_with_max_1s;

Solution solution = new();
Console.WriteLine(solution.RowWithMax1s([[0, 1, 1, 1],
               [0, 0, 1, 1],
               [1, 1, 1, 1],
               [0, 0, 0, 0]]));
Console.WriteLine(solution.RowWithMax1s([[0, 0],
               [1, 1]]));
Console.WriteLine(solution.RowWithMax1s([
    [0, 0, 0, 1, 1, 1, 1, 1, 1],
    [0, 0, 0, 0, 1, 1, 1, 1, 1],
    [0, 0, 0, 0, 1, 1, 1, 1, 1]]));
