namespace Minimum_Jumps
{
    internal class Solution
    {
        public int MinJumps(int[] arr)
        {
            int n = arr.Length;
            if (n <= 1)
            {
                return 0;
            }

            if (arr[0] == 0)
            {
                return -1;
            }

            int maxReacheble = 0;
            int curReacheble = 0;
            int jumps = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i > maxReacheble)
                {
                    return - 1;
                }

                if (i > curReacheble)
                {
                    curReacheble = maxReacheble;
                    ++jumps;
                }

                maxReacheble = Math.Max(maxReacheble, i + arr[i]);
            }

            return jumps;
        }
    }
}
