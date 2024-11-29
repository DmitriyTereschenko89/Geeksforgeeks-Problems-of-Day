namespace Smallest_window_in_a_string_containing
{
    internal class Solution
    {
        public string SmallestWindow(string s, string p)
        {
            Dictionary<char, int> pDict = [];
            foreach (char c in p)
            {
                pDict[c] = pDict.GetValueOrDefault(c) + 1;
            }

            Dictionary<char, int> dict = [];
            int targetUniqueValues = pDict.Count;
            int uniqueValues = 0;
            string ans = "-1";
            int left = 0;
            for (int right = 0; right < s.Length; ++right)
            {
                char c = s[right];
                if (pDict.TryGetValue(c, out int freqs))
                {
                    dict[c] = dict.GetValueOrDefault(c) + 1;
                    if (dict[c] == freqs)
                    {
                        ++uniqueValues;
                    }

                    while (uniqueValues == targetUniqueValues)
                    {
                        char ch = s[left];
                        if (ans == "-1" || ans.Length > right - left + 1)
                        {
                            ans = s[left..(right + 1)];
                        }

                        if (dict.TryGetValue(ch, out _))
                        {
                            --dict[ch];
                            if (dict[ch] < pDict[ch])
                            {
                                if (dict[ch] == 0)
                                {
                                    dict.Remove(ch);
                                }

                                --uniqueValues;
                            }
                        }

                        ++left;
                    }
                }
            }

            return ans;
        }
    }
}
