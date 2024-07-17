namespace Shortest_Path_in_Weighted_undirected_graph
{
    using System.Collections.Generic;

    internal class MinHeap
    {
        private readonly List<Node> _heap = [];

        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = curIdx * 2 + 2;
                if (childTwoIdx <= endIdx && _heap[childTwoIdx]._distance < _heap[childOneIdx]._distance)
                {
                    swapIdx = childTwoIdx;
                }
                if (_heap[swapIdx]._distance < _heap[curIdx]._distance)
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
            while (parentIdx >= 0 && _heap[parentIdx]._distance > _heap[curIdx]._distance)
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
            _heap.Add(new Node(node, distance));
            SiftUp(_heap.Count - 1);
        }

        public Node Pop()
        {
            (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
            Node removed = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removed;
        }
    }
}
