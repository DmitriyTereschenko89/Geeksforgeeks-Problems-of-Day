using K_Sized_Subarray_Maximum;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.MaxOfSubarrays(3, [1, 2, 3, 1, 4, 5, 2, 3, 6])));
Console.WriteLine(string.Join(", ", solution.MaxOfSubarrays(4, [8, 5, 10, 7, 9, 4, 15, 12, 90, 13])));
