namespace Print_N_bit_binary_numbers_having_more_1s_than_0s
{
	public class Solution
	{
		private void DFS(int n, int zeroCount, int oneCount, List<string> ans, List<char> curSeq)
		{
			if (zeroCount > oneCount)
			{
				return;
			}
			if (curSeq.Count == n)
			{
				ans.Add(new string(curSeq.ToArray()));
				return;
			}
			curSeq.Add('0');
			DFS(n, zeroCount + 1, oneCount, ans, curSeq);
			curSeq.RemoveAt(curSeq.Count - 1);
			curSeq.Add('1');
			DFS(n, zeroCount, oneCount + 1, ans, curSeq);
			curSeq.RemoveAt(curSeq.Count - 1);
		}
		public List<string> NBitBinary(int n)
		{
			List<string> ans = [];
			DFS(n, 0, 0, ans, []);
			ans.Sort((a, b) => b.CompareTo(a));
			return ans;
		}
	}
}
