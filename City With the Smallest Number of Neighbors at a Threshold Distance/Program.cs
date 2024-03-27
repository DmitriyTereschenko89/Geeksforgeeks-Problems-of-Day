using City_With_the_Smallest_Number_of_Neighbors_at_a_Threshold_Distance;

int n = 5;
int m = 5;
List<List<int>> edges = [[0, 1, 2],
		 [0, 4, 8],
		 [1, 2, 3],
		 [1, 4, 2],
		 [2, 3, 1],
		 [3, 4, 1]];
Solution solution = new();
Console.WriteLine(solution.FindCity(n, m, edges, 4));