namespace Maximum_Difference
{
    internal class Solution
    {
        public int FindMaxDiff(int[] arr)
        {
            int n = arr.Length;
            int[] leftMin = new int[n];
            int[] rightMin = new int[n];

            Stack<int> st = [];
            for (int i = 0; i < n; ++i)
            {
                while (st.Count > 0 && st.Peek() >= arr[i])
                {
                    st.Pop();
                }

                leftMin[i] = st.Count == 0 ? 0 : st.Peek();
                st.Push(arr[i]);
            }

            st.Clear();
            for (int i = n - 1; i >= 0; --i)
            {
                while (st.Count > 0 && st.Peek() >= arr[i])
                {
                    st.Pop();
                }

                rightMin[i] = st.Count == 0 ? 0 : st.Peek();
                st.Push(arr[i]);
            }

            int maxDiff = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                maxDiff = Math.Max(maxDiff, Math.Abs(leftMin[i] - rightMin[i]));
            }

            return maxDiff;
        }
    }
}
