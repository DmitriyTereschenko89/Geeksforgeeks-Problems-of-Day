namespace Sorted_subsequence_of_size_3
{
    internal class Solution
    {
        public int[] Find3Numbers(int[] arr)
        {
            int n = arr.Length;
            int[] leftSmaller = new int[n];
            int[] rightLarger = new int[n];
            leftSmaller[0] = arr[0];
            for (int i = 1; i < n; ++i)
            {
                leftSmaller[i] = Math.Min(leftSmaller[i - 1], arr[i]);
            }


            rightLarger[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                rightLarger[i] = Math.Max(rightLarger[i + 1], arr[i]);
            }


            for (int i = 1; i < n - 1; ++i)
            {
                if (arr[i] > leftSmaller[i - 1] && arr[i] < rightLarger[i + 1])
                {
                    return [leftSmaller[i - 1], arr[i], rightLarger[i + 1]];
                }
            }


            return [];
        }
    }
}
