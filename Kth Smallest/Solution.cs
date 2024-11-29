namespace Kth_Smallest
{
    internal class Solution
    {
        public int KthSmallest(int[] arr, int k)
        {
            int maxNum = arr.Max();
            int[] freqs = new int[maxNum + 1];
            for (int i = 0; i < arr.Length; ++i)
            {
                ++freqs[arr[i]];
            }

            for (int num = 0; num <= maxNum; ++num)
            {
                k -= freqs[num];
                if (k <= 0)
                {
                    return num;
                }
            }

            return -1;
        }
    }
}
