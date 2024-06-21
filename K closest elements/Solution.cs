using System.Numerics;

namespace K_closest_elements
{
    internal class Solution
    {
        public List<int> PrintKClosest(List<int> arr, int n, int k, int x)
        {
            MinHeap heap = new();
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] != x)
                {
                    heap.Push(new(arr[i], Math.Abs(arr[i] - x), i));
                }
            }

            List<int> closestElements = [];
            while (heap.Size() > 0 && k > 0)
            {
                closestElements.Add(heap.Pop().elem);
                --k;
            }

            return closestElements;
        }
    }
}
