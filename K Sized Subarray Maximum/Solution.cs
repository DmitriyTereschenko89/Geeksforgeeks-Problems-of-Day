namespace K_Sized_Subarray_Maximum
{
    internal class Solution
    {
        public List<int> MaxOfSubarrays(int k, int[] arr)
        {
            List<int> subarrays = [];
            Deque dq = new();
            for (int i = 0; i < k; ++i)
            {
                while (!dq.IsEmpty() && arr[dq.PeekLast()] <= arr[i])
                {
                    dq.PopLast();
                }

                dq.Push(i);
            }

            subarrays.Add(arr[dq.PeekFirst()]);
            for (int i = k; i < arr.Length; ++i)
            {
                if (dq.PeekFirst() == i - k)
                {
                    dq.PopFirst();
                }

                while (!dq.IsEmpty() && arr[dq.PeekLast()] <= arr[i])
                {
                    dq.PopLast();
                }

                dq.Push(i);
                subarrays.Add(arr[dq.PeekFirst()]);
            }

            return subarrays;
        }
    }
}
