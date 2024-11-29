namespace Longest_Prefix_Suffix
{
    internal class Solution
    {
        public int LPS(string str)
        {
            int n = str.Length;
            int len = 0;
            int index = 1;
            int[] lps = new int[n];
            while (index < n)
            {
                if (str[len] == str[index])
                {
                    ++len;
                    lps[index] = len;
                    ++index;
                    
                }
                else
                {
                    if (len == 0)
                    {
                        lps[index] = 0;
                        ++index;
                    }
                    else
                    {
                        len = lps[len - 1];
                    }
                }
            }

            return lps[^1];
        }
    }
}
