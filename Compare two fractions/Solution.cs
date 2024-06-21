namespace Compare_two_fractions
{
    internal class Solution
    {
        private List<int> GetFrac(string frac)
        {
            List<int> ans = [];
            for (int r = 0; r < frac.Length; ++r)
            {
                int num = 0;
                while (r < frac.Length && frac[r] != '/')
                {
                    num = num * 10 + (frac[r] - '0');
                    ++r;
                }

                ans.Add(num);
            }

            return ans;
        }
        public string CompareFrac(string str)
        {
            string[] parts = str.Split(", ");
            List<int> frac1 = GetFrac(parts[0]);
            List<int> frac2 = GetFrac(parts[1]);
            int num1 = frac1[0] * frac2[1];
            int num2 = frac1[1] * frac2[0];
            if (num1 > num2)
            {
                return parts[0];
            }
            else if (num1 < num2)
            {
                return parts[1];
            }

            return "equal";
        }
    }
}
