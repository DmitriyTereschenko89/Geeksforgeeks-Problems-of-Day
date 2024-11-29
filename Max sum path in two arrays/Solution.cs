namespace Max_sum_path_in_two_arrays
{
    internal class Solution
    {
        public int MaxPathSum(int[] arr1, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;
            int pathSum = 0;
            int i = 0;
            int j = 0;
            int n = arr1.Length;
            int m = arr2.Length;
            while (i < n && j < m)
            {
                if (arr1[i] == arr2[j])
                {
                    pathSum = pathSum + arr1[i] + Math.Max(sum1, sum2);
                    ++i;
                    ++j;
                    sum1 = sum2 = 0;
                }    
                else if (arr1[i] < arr2[j])
                {
                    sum1 += arr1[i++];
                }
                else
                {
                    sum2 += arr2[j++];
                }
            }

            while (i < n)
            {
                sum1 += arr1[i++];
            }

            while (j < m)
            {
                sum2 += arr2[j++];
            }

            pathSum += Math.Max(sum1, sum2);
            return pathSum;
        }
    }
}
