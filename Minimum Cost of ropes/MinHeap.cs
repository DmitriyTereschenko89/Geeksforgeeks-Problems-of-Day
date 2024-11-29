namespace Minimum_Cost_of_ropes
{
    internal class MinHeap
    {
        private readonly List<long> _heap = [];

        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = curIdx * 2 + 2;
                if (childTwoIdx <= endIdx && _heap[childTwoIdx] < _heap[childOneIdx])
                {
                    swapIdx = childTwoIdx;
                }

                if (_heap[swapIdx] < _heap[curIdx])
                {
                    (_heap[curIdx], _heap[swapIdx]) = (_heap[swapIdx], _heap[curIdx]);
                    curIdx = swapIdx;
                    childOneIdx = curIdx * 2 + 1;
                }
                else
                {
                    return;
                }
            }
        }

        private void SiftUp(int curIdx)
        {
            int parentIdx = (curIdx - 1) / 2;
            while (parentIdx >= 0 && _heap[parentIdx] > _heap[curIdx])
            {
                (_heap[curIdx], _heap[parentIdx]) = (_heap[parentIdx], _heap[curIdx]);
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public void Push(long data)
        {
            _heap.Add(data);
            SiftUp(_heap.Count - 1);
        }

        public long Pop()
        {
            (_heap[^1], _heap[0]) = (_heap[0], _heap[^1]);
            long removed = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removed;
        }

        public int Count()
        {
            return _heap.Count;
        }
    }
}
