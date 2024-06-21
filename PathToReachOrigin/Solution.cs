namespace PathToReachOrigin
{
    public class Solution
    {
        public long Ways(int x, int y)
        {
            int modulo = 1000000007;
            int[][] dp = new int[x + 1][];
            for (int r = 0; r <= x; ++r)
            {
                dp[r] = new int[y + 1];
            }
            for (int i = 1; i <= x; ++i)
            {
                dp[i][0] = 1;
            }
            for (int i = 1; i <= y; ++i)
            {
                dp[0][i] = 1;
            }
            for (int i = 1; i <= x; ++i)
            {
                for (int j = 1; j <= y; ++j)
                {
                    dp[i][j] = (dp[i - 1][j] + dp[i][j - 1]) % modulo;
                }
            }
            return dp[x][y];
        }
    }
}
