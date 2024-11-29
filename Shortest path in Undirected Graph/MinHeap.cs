namespace Shortest_path_in_Undirected_Graph
{
    using System.Collections.Generic;

    internal class MinHeap
    {
        private readonly List<(int, int)> _heap = [];

        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = curIdx * 2 + 2;
                if (childTwoIdx <= endIdx && _heap[childTwoIdx].Item2 < _heap[childOneIdx].Item2)
                {
                    swapIdx = childTwoIdx;
                }
                if (_heap[swapIdx].Item2 < _heap[curIdx].Item2)
                {
                    (_heap[swapIdx], _heap[curIdx]) = (_heap[curIdx], _heap[swapIdx]);
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
            while (parentIdx >= 0 && _heap[parentIdx].Item2 > _heap[curIdx].Item2)
            {
                (_heap[parentIdx], _heap[curIdx]) = (_heap[curIdx], _heap[parentIdx]);
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }

        public void Push(int node, int distance)
        {
            _heap.Add((node, distance));
            SiftUp(_heap.Count - 1);
        }

        public (int, int) Pop()
        {
            (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
            (int, int) removed = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removed;
        }
    }
}
