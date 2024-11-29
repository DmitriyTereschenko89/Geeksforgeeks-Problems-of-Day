namespace Minimum_Cost_of_ropes
{
    internal class Solution
    {
        public long MinCost(long[] arr)
        {
            MinHeap heap = new();
            for (int i = 0; i < arr.Length; ++i)
            {
                heap.Push(arr[i]);
            }

            long minCost = 0;
            while (heap.Count() > 1)
            {
                long prevMin = heap.Pop();
                long min = heap.Pop();
                long newRopeLength = prevMin + min;
                minCost += newRopeLength;
                heap.Push(newRopeLength);
            }

            return minCost;
        }
    }
}
