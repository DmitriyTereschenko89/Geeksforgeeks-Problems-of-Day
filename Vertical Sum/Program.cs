using Vertical_Sum;

Solution solution = new();
Node root = new(1, new(2, new(4), new(5)), new(3, new(6), new(7)));
Console.WriteLine(string.Join(", ", solution.VerticalSum(root)));