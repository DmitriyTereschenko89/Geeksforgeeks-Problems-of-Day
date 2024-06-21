namespace Sum_of_all_substrings_of_a_number
{
	public class Solution
	{
		public long SumSubstrings(string s)
		{
			int n = s.Length;
			const long modulo = 1000000007;
			long[] dp = new long[n];
			dp[0] = s[0] - '0';
			long ans = dp[0];
			for (int i = 1; i < n; ++i)
			{
				dp[i] = ((dp[i - 1] * 10 % modulo % modulo) + ((s[i] - '0') * (i + 1) % modulo)) % modulo;
				ans = (ans + dp[i]) % 1000000007;
			}
			return ans;
		}
	}
}
