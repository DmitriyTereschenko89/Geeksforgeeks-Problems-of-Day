namespace K_closest_elements
{
    public class MinHeap
    {
        private readonly List<CloseElement> _elements = [];
        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = curIdx * 2 + 2;
                if (childTwoIdx <= endIdx && ((_elements[childTwoIdx].absDiff == _elements[childOneIdx].absDiff) ?
                                                _elements[childTwoIdx].index > _elements[childOneIdx].index :
                                                _elements[childTwoIdx].absDiff < _elements[childOneIdx].absDiff))
                {
                    swapIdx = childTwoIdx;
                }

                if (_elements[swapIdx].absDiff == _elements[curIdx].absDiff ?
                    _elements[curIdx].index < _elements[swapIdx].index :
                    _elements[swapIdx].absDiff < _elements[curIdx].absDiff)
                {
                    (_elements[curIdx], _elements[swapIdx]) = (_elements[swapIdx], _elements[curIdx]);
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
            while (parentIdx >= 0 && ((_elements[parentIdx].absDiff == _elements[curIdx].absDiff) ?
                                                _elements[curIdx].index > _elements[parentIdx].index :
                                                _elements[curIdx].absDiff < _elements[parentIdx].absDiff))
            {
                (_elements[parentIdx], _elements[curIdx]) = (_elements[curIdx], _elements[parentIdx]);
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public void Push(CloseElement closeElement)
        {
            _elements.Add(closeElement);
            SiftUp(_elements.Count - 1);
        }

        public CloseElement Pop()
        {
            (_elements[0], _elements[^1]) = (_elements[^1], _elements[0]);
            CloseElement removedElement = _elements[^1];
            _elements.RemoveAt(_elements.Count - 1);
            SiftDown(0, _elements.Count - 1);
            return removedElement;
        }

        public int Size()
        {
            return _elements.Count;
        }
    }
}
