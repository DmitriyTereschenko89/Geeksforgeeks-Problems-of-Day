namespace K_Palindrome
{
    internal class Solution
    {
        public int kPalindrome(string str, int n, int k)
        {
            int[][] dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
            {
                dp[i] = new int[n + 1];
            }

            for (int r = 1; r <= n; ++r)
            {
                for (int c = 1; c <= n; ++c)
                {
                    dp[r][c] = str[r - 1] == str[n - c] ? 1 + dp[r - 1][c - 1] : Math.Max(dp[r - 1][c], dp[r][c - 1]);
                }
            }
            return n - dp[n][n] <= k ? 1 : 0;
        }
    }
}
