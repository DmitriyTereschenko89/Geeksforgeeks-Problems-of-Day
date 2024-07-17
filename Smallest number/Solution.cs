namespace Smallest_number
{
    internal class Solution
    {
        private int smallestNumber = int.MaxValue;
        private void DFS(int curSum, int number, int curDigit, int target, int d)
        {
            if (curDigit == d)
            {
                if (curSum == target)
                {
                    smallestNumber = Math.Min(smallestNumber, number);
                }

                return;
            }

            int num = curDigit == 0 ? 1 : 0;
            for (; num <= 9; ++num)
            {
                int newNumber = number * 10 + num;
                DFS(curSum + num, newNumber, curDigit + 1, target, d);
            }
        }

        public string SmallestNumber(int s, int d)
        {
            smallestNumber = int.MaxValue;
            DFS(0, 0, 0, s, d);

            return smallestNumber == int.MaxValue ? "-1" : smallestNumber.ToString();
        }
    }
}
