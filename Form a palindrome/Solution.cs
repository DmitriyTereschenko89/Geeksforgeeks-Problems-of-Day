namespace Form_a_palindrome
{
    using System;
    using System.Linq;

    internal class Solution
    {
        private int LCS(string str1, string str2, int m, int n)
        {
            int[][] dp = new int[m + 1][];
            for (int i = 0; i <= m; ++i)
            {
                dp[i] = new int[n + 1];
            }

            for (int i = 0; i <= m; ++i)
            {
                for (int j = 0; j <= n; ++j)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i][j] = 0;
                    }
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i][j] = 1 + dp[i - 1][j - 1];
                    }
                    else
                    {
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                    }
                }
            }

            return dp[m][n];
        }

        public int CountMin(string str)
        {
            int n = str.Length;
            string reversedStr = new(str.Reverse().ToArray());
            return n - LCS(str, reversedStr, n, n);
        }
    }
}
