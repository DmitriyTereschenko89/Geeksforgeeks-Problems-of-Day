namespace Minimum_cost_to_fill_given_weight_in_a_bag
{
    public class Solution
    {
        public int MinimumCost(int n, int w, int[] cost)
        {
            int[] dp = new int[w + 1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j <= w; ++j)
                {
                    dp[j] = Math.Min(dp[j], dp[j - (i + 1)] + cost[i]);
                }
            }

            return dp[w] > 0 ? dp[w] : -1;
        }
    }
}