namespace Minimum_repeat_to_make_substring
{
    internal class Solution
    {
        private int[] GetPattern(string s)
        {
            int n = s.Length;
            int[] pattern = new int[n];
            Array.Fill(pattern, -1);
            int j = 0;
            int i = 1;
            while (i < n)
            {
                if (s[i] == s[j])
                {
                    pattern[i++] = j++;                    
                }
                else if (j > 0)
                {
                    j = pattern[j - 1] + 1;
                }
                else
                {
                    ++i;
                }
            }

            return pattern;
        }

        private bool KMPSearch(string s1, string s2, int[] pattern, int repeats)
        {
            int n = s1.Length;
            int m = s2.Length;
            int i = 0;
            int j = 0;
            while (i < n * repeats)
            {
                if (s1[i % n] == s2[j])
                {
                    if (j == s2.Length - 1)
                    {
                        return true;
                    }

                    ++i;
                    ++j;
                }
                else if (j > 0)
                {
                    j = pattern[j - 1] + 1;
                }
                else
                {
                    ++i;
                }
            }

            return false;
        }

        public int MinRepeats(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;
            int[] pattern = GetPattern(s2);
            int repeats = (n + m - 1) / n;
            if (KMPSearch(s1, s2, pattern, repeats))
            {
                return repeats;
            }

            if (KMPSearch(s1, s2, pattern, repeats + 1))
            {
                return repeats + 1;
            }

            return -1;
        }
    }
}
