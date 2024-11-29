namespace Minimal_Cost
{
    internal class Solution
    {
        public int MinimizeCost(int k, int[] arr)
        {
            int n = arr.Length;
            int[] dp = new int[n];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 1; j <= k && i + j < n; ++j)
                {
                    dp[i + j] = Math.Min(dp[i + j], dp[i] + Math.Abs(arr[i] - arr[i + j]));
                }
            }

            return dp[n - 1];
        }
    }
}
