using Print_N_bit_binary_numbers_having_more_1s_than_0s;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<string> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	ans.Add(string.Join(",", solution.NBitBinary(n)));
}
Console.WriteLine(string.Join("\n", ans));