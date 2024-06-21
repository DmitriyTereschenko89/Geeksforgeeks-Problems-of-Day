using K_closest_elements;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.PrintKClosest([12, 16, 22, 30, 35, 39, 42, 45, 48, 50, 53, 55, 56], 13, 4, 35)));
Console.WriteLine(string.Join(", ", solution.PrintKClosest([1, 2, 3, 6, 10], 5, 3, 4)));