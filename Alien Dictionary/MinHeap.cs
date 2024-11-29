namespace Alien_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MinHeap
    {
        private readonly List<char> _heap;

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
                    char temp = _heap[curIdx];
                    _heap[curIdx] = _heap[swapIdx];
                    _heap[swapIdx] = temp;
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
                char temp = _heap[curIdx];
                _heap[curIdx] = _heap[parentIdx];
                _heap[parentIdx] = temp;
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public MinHeap()
        {
            _heap = new List<char>();
        }

        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }

        public void Push(char ch)
        {
            _heap.Add(ch);
            SiftUp(_heap.Count - 1);
        }

        public char Pop()
        {
            char temp = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap[_heap.Count - 1] = temp;
            char removed = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removed;
        }
    }
}
