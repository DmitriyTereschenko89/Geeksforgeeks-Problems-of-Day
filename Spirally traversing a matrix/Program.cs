using Spirally_traversing_a_matrix;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.SpirallyTraverse(
    [[1, 2, 3, 4],
     [5, 6, 7, 8],
     [9, 10, 11, 12],
     [13, 14, 15,16]])));
Console.WriteLine(string.Join(", ", solution.SpirallyTraverse(
    [[1, 2, 3, 4],
     [5, 6, 7, 8],
     [9, 10, 11, 12]])));
Console.WriteLine(string.Join(", ", solution.SpirallyTraverse(
    [[32, 44, 27, 23],
     [54, 28, 50, 62]])));
