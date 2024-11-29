namespace Add_Binary_Strings
{
    using System.Linq;

    internal class Solution
    {
        public string AddBinary(string s1, string s2)
        {
            int i = s1.Length - 1;
            int j = s2.Length - 1;
            int remainder = 0;
            List<char> res = [];
            while (i >= 0 || j >= 0)
            {
                int bit1 = i >= 0 ? s1[i] - '0' : 0;
                int bit2 = j >= 0 ? s2[j] - '0' : 0;
                int curSum = bit1 + bit2 + remainder;
                res.Add((char)((curSum % 2) + '0'));
                remainder = curSum / 2;
                --i;
                --j;
            }

            if (remainder > 0)
            {
                res.Add((char)(remainder + '0'));
            }

            res.Reverse();
            res = res.SkipWhile(x => x == '0').ToList();
            return string.Join("", res);
        }
    }
}
