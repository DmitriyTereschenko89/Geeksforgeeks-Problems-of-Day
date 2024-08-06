using The_Celebrity_Problem;

Solution solution = new();
Console.WriteLine(solution.Celebrity(
    [
        [0, 1, 0],
        [0, 0, 0],
        [0, 1, 0]
    ]));
Console.WriteLine(solution.Celebrity(
    [
        [0, 1],
        [1, 0]
    ]));
Console.WriteLine(solution.Celebrity(
    [
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0]
    ]));
