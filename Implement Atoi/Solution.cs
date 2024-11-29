namespace Implement_Atoi
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            char[] stringChars = s.ToCharArray();
            int startIndex = 0;
            int endIndex = stringChars.Length - 1;
            int totalValue = 0;
            int sign = 1;
            HashSet<char> signs = new HashSet<char>();
            while (startIndex < endIndex && char.IsWhiteSpace(stringChars[startIndex]))
            {
                startIndex++;
            }

            if (startIndex > endIndex)
            {
                return 0;
            }

            if (!char.IsDigit(stringChars[startIndex]) && stringChars[startIndex] != '-' && stringChars[startIndex] != '+')
            {
                return 0;
            }

            while (endIndex >= 0 && (char.IsWhiteSpace(stringChars[endIndex]) || !char.IsDigit(stringChars[endIndex])))
            {
                endIndex--;
            }

            if (startIndex > endIndex)
            {
                return 0;
            }

            if (stringChars[startIndex] == '-')
            {
                sign = -1;
                signs.Add('-');
                startIndex++;
            }
            else if (stringChars[startIndex] == '+')
            {
                startIndex++;
                signs.Add('+');
            }

            int firstIndex = startIndex;
            while (startIndex <= endIndex)
            {
                if ((firstIndex != startIndex) && (stringChars[startIndex] == '-' || stringChars[startIndex] == '+'))
                {
                    return totalValue * sign;
                }
                else if ((stringChars[startIndex] == '-' || stringChars[startIndex] == '+') && signs.Contains(stringChars[startIndex]))
                {
                    return 0;
                }
                else if (stringChars[startIndex] == '.' || !char.IsDigit(stringChars[startIndex]))
                {
                    break;
                }

                int previousResult = totalValue;
                totalValue *= 10;
                int highLevel = stringChars[startIndex++] - '0';
                totalValue += highLevel;
                if ((previousResult > int.MaxValue / 10 || (previousResult == int.MaxValue / 10 && highLevel > 7)))
                {
                    return (sign == 1) ? int.MaxValue : int.MinValue;
                }
            }

            return totalValue * sign;
        }
    }
}
