namespace Sum_of_Middle_elements_of_two_sorted_arrays
{
    internal class Solution
    {
        public int SumOfMiddleElements(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int left = 0;
            int right = n;
            while (left <= right)
            {
                int middle1 = (left + right) / 2;
                int middle2 = n - middle1;

                int left1 = middle1 == 0 ? int.MinValue : arr1[middle1 - 1];
                int left2 = middle2 == 0 ? int.MinValue : arr2[middle2 - 1];
                int right1 = middle1 == n ? int.MaxValue : arr1[middle1];
                int right2 = middle2 == n ? int.MaxValue : arr2[middle2];

                if (left1 <= right2 &&  left2 <= right1)
                {
                    return Math.Max(left1, left2) + Math.Min(right1, right2);
                }

                if (left1 > right2)
                {
                    right = middle1 - 1;
                }
                else
                {
                    left = middle1 + 1;
                }
            }

            return -1;
        }
    }
}
