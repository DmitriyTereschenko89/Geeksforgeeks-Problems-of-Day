namespace Missing_And_Repeating
{
    internal class Solution
    {
        public int[] FindTwoElement(int[] arr)
        {
            int n = arr.Length;
            long arrSum = arr.Sum();
            long targetSum = (n * (n + 1)) / 2;
            int duplicateNumber = -1;
            for (int i = 0; i < n; ++i)
            {
                int num = Math.Abs(arr[i]);
                if (arr[num - 1] < 0)
                {
                    duplicateNumber = num;
                    break;
                }

                arr[num - 1] *= -1;
            }

            return [duplicateNumber, (int)(targetSum - (arrSum - duplicateNumber))];
        }
    }
}
