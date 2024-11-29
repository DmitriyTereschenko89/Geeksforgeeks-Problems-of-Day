namespace Total_count
{
    internal class Solution
    {
        public int TotalCount(int k, int[] arr)
        {
            int totalCount = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                int parts = arr[i] / k;
                int remainder = Math.Min(1, arr[i] % k);
                totalCount += parts + remainder;
            }

            return totalCount;
        }
    }
}
