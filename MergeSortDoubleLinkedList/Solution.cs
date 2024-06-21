using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortDoubleLinkedList
{
    internal class Solution
    {
        private Node GetMiddleNode(Node start)
        {
            Node slow = start;
            Node fast = start;
            while (fast._next != null && fast._next._next != null)
            {
                slow = slow._next;
                fast = fast._next._next;
            }

            return slow;
        }

        private Node Merge(Node l1, Node l2)
        {
            if (l1 is null)
            {
                return l2;
            }

            if (l2 is null)
            {
                return l1;
            }
            if (l1._data <= l2._data)
            {
                l1._next = Merge(l1._next, l2);
                l1._next._prev = l1;
                l1._prev = null;
                return l1;
            }
            else
            {
                l2._next = Merge(l1, l2._next);
                l2._next._prev = l2;
                l2._prev = null;
                return l2;
            }
        }

        private Node MergeSort(Node head)
        {
            if (head is null || head._next == null)
            {
                return head;
            }

            Node midNode = GetMiddleNode(head);
            Node next = midNode._next;
            midNode._next = null;
            Node l1 = MergeSort(head);
            Node l2 = MergeSort(next);
            return Merge(l1, l2);            
        }

        public Node SortDoubly(Node head)
        {
            if (head is null || head._next is null)
            {
                return head;
            }
            return MergeSort(head);
        }
    }
}
