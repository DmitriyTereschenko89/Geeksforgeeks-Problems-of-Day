namespace K_Sized_Subarray_Maximum
{
    internal class Deque
    {
        private Node _head;
        private Node _tail;

        public Deque()
        {
            _head = null;
            _tail = null;
        }

        public void Push(int data)
        {
            Node _newNode = new(data);
            if (_head is null)
            {
                _head = _newNode;
                _tail = _head;
                return;
            }
            
            _tail._next = _newNode;
            _newNode._prev = _tail;
            _tail = _newNode;
        }

        public bool IsEmpty()
        {
            return _head is null;
        }

        public void PopFirst()
        {
            if (_head == _tail)
            {
                _head = _tail = null;
                return;
            }

            _head = _head._next;
            _head._prev = null;
        }

        public void PopLast()
        {
            if (_head == _tail)
            {
                _head = _tail = null;
                return;
            }

            _tail = _tail._prev;
            _tail._next = null;
        }

        public int PeekLast()
        {
            return _tail._data;
        }

        public int PeekFirst()
        {
            return _head._data;
        }
    }
}
