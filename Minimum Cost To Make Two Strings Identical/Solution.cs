namespace Minimum_Cost_To_Make_Two_Strings_Identical
{
    internal class Solution
    {
        public int FindMinCost(string x, string y, int costX, int costY)
        {
            int n = x.Length;
            int m = y.Length;
            int[,] dp = new int[n + 1, m + 1];
            for (int i = 0; i <= m; ++i)
            {
                dp[0, i] = i * costY;
            }

            for (int i = 0; i <= n; ++i)
            {
                dp[i, 0] = i * costX;
            }

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    if (x[i - 1] == y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        int deletedFromX = costX + dp[i - 1, j];
                        int deletedFromY = costY + dp[i, j - 1];
                        dp[i, j] = Math.Min(deletedFromX, deletedFromY);
                    }
                }
            }

            return dp[n, m];
        }
    }
}
