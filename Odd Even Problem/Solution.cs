namespace Odd_Even_Problem
{
    internal class Solution
    {
        public string OddEven(string s)
        {
            Console.WriteLine(s);
            int[] freqs = new int[26];
            for (int i = 0; i < s.Length; ++i)
            {
                ++freqs[s[i] - 'a'];
            }
            for (int i = 0; i < 26; ++i)
            {
                if (freqs[i] != 0)
                {
                    Console.WriteLine($"{i + 1}-{(char)(i + 'a')}-{freqs[i]}");
                }
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < 26; ++i)
            {
                if (freqs[i] != 0)
                {
                    if ((((i + 1) & 1) == 0) && ((freqs[i] & 1) == 0))
                    {
                        ++x;
                    }
                    else if ((((i + 1) & 1) == 1) && ((freqs[i] & 1) == 1))
                    {
                        ++y;
                    }
                }
            }

            Console.WriteLine(x + y);
            return ((x + y) & 1) == 0 ? "EVEN" : "ODD";
        }
    }
}
