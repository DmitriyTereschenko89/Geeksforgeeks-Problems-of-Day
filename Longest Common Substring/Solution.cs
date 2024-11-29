namespace Longest_Common_Substring
{
    using System;

    internal class Solution
    {
        public int longestCommonSubstr(string str1, string str2)
        {
            int n = str1.Length;
            int m = str2.Length;
            int[][] dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
            {
                dp[i] = new int[m + 1];
            }

            int maxLength = 0;
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i][j] = 1 + dp[i - 1][j - 1];
                        maxLength = Math.Max(maxLength, dp[i][j]);
                    }
                }
            }
            
            return maxLength;
        }
    }
}
