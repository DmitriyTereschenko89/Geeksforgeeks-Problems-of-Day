namespace Deletion_and_Reverse_in_Circular_Linked_List
{
    internal class Solution
    {
        //Function to reverse a circular linked list
        public Node Reverse(Node head)
        {
            if (head is null)
            {
                return null;
            }

            Node prev = null;
            Node cur = head;
            while (cur != null)
            {
                Node next = cur._next;
                cur._next = prev;
                prev = cur;
                cur = next;
                if (cur == head)
                {
                    break;
                }
            }

            head._next = prev;

            return prev;
        }

        //Function to delete a node from the circular linked list
        public Node DeleteNode(Node head, int key)
        {
            if (head is null)
            {
                return null;
            }

            Node cur = head;
            Node prev = cur;
            Node temp = cur._next;
            if (head._data == key)
            {
                while (prev._next != head)
                {
                    prev = prev._next;
                }

                prev._next = temp;
                return head;
            }

            while (temp != head)
            {
                if (temp._data == key)
                {
                    prev._next = temp._next;
                    return head;
                }

                prev = temp;
                temp = temp._next;
            }

            return head;
        }
    }
}
