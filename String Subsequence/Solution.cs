namespace String_Subsequence
{
    internal class Solution
    {
        private int modulo = 1000000007;
        private int[][] dp;

        private int CountWaysHelper(string s1, string s2, int i, int j)
        {
            if (i >= s1.Length)
            {
                return 0;
            }

            if (j >= s2.Length)
            {
                return 1;
            }

            if (dp[i][j] != -1)
            {
                return dp[i][j];
            }

            int noSkip = 0;
            if (s1[i] == s2[j])
            {
                noSkip = (noSkip + CountWaysHelper(s1, s2, i + 1, j + 1)) % modulo;
            }

            int skip = CountWaysHelper(s1, s2, i + 1, j) % modulo;
            dp[i][j] = (noSkip + skip) % modulo;

            return dp[i][j];
        }

        public int CountWays(string s1, string s2)
        {
            ////int n = s1.Length;
            ////int m = s2.Length;
            ////dp = new int[n][];
            ////for (int i = 0; i < n; ++i)
            ////{
            ////    dp[i] = new int[m];
            ////    Array.Fill(dp[i], -1);
            ////}

            ////return CountWaysHelper(s1, s2, 0, 0);
            int[] dp = new int[s2.Length];
            for (int i = 0; i < s1.Length; ++i)
            {
                for (int j = s2.Length - 1; j >= 0; --j)
                {
                    if (s1[i] == s2[j])
                    {
                        dp[j] = j == 0 ? (dp[j] + 1) % modulo : (dp[j] + dp[j - 1]) % modulo;
                    }
                }
            }

            return dp[s2.Length - 1];
        }
    }
}
