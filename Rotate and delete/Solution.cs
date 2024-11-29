namespace Rotate_and_delete
{
    internal class Solution
    {
        public int RotateDelete(List<int> arr)
        {
            int n = arr.Count;
            int start = 0;
            for (int i = 1; i <= n / 2; ++i)
            {
                start = Math.Abs(start - 1) % arr.Count;
                int deleteIndex = (start + n - i) % arr.Count;
                arr.RemoveAt(deleteIndex);
                if (deleteIndex <= start)
                {
                    --start;
                }

                --n;
            }

            return arr[start];
        }
    }
}
