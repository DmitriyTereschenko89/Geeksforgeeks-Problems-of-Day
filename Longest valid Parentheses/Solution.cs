namespace Longest_valid_Parentheses
{
    internal class Solution
    {
        private int LongestValidParentheses(string str, int direction = 0)
        {
            int longestValidParentheses = 0;
            int openBrackets = 0;
            int closeBrackets = 0;
            int startPosition = 0;
            int endPosition = str.Length;
            int step = 1;
            if (direction == 1)
            {
                startPosition = endPosition - 1;
                endPosition = 0;
                step *= -1;
            }

            while (startPosition !=  endPosition)
            {
                if (str[startPosition]  == '(')
                {
                    ++openBrackets;
                }
                else
                {
                    ++closeBrackets;
                }

                if (openBrackets == closeBrackets)
                {
                    longestValidParentheses = Math.Max(longestValidParentheses, openBrackets + closeBrackets);
                }

                bool isReset = direction == 0 ? closeBrackets > openBrackets : openBrackets > closeBrackets;
                if (isReset)
                {
                    openBrackets = 0;
                    closeBrackets = 0;
                }

                startPosition += step;
            }

            return longestValidParentheses;
        }

        public int MaxLength(string str)
        {
            return Math.Max(LongestValidParentheses(str), LongestValidParentheses(str, 1));
        }
    }
}
