namespace Print_Bracket_Number
{
    using System.Collections.Generic;

    internal class Solution
    {
        public List<int> BracketNumbers(string str)
        {
            Stack<int> st = [];
            List<int> ans = [];
            int brackets = 1;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '(')
                {
                    ans.Add(brackets);
                    st.Push(brackets++);
                }
                else if (str[i] == ')')
                {
                    ans.Add(st.Pop());
                }
            }

            return ans;
        }
    }
}
