namespace Palindrome_Linked_List
{
    internal class Solution
    {
        private Node ReverseLL(Node head)
        {
            Node prev = null;
            Node node = head;
            while (node != null)
            {
                Node next = node._next;
                node._next = prev;
                prev = node;
                node = next;
            }

            return prev;
        }

        public bool IsPalindrome(Node head)
        {
            Node prev = null;
            Node slow = head;
            Node fast = head;
            while(fast != null && fast._next != null)
            {
                prev = slow;
                slow = slow._next;
                fast = fast._next._next;
            }

            Node head1 = prev ?? slow._next;
            if (prev != null)
            {
                prev._next = null;
            }
            else
            {
                slow._next = null;
            }

            head1 = ReverseLL(head1);
            slow = head;
            while (slow != null && head1 != null)
            {
                if (slow._data != head._data)
                {
                    return false;
                }

                slow = slow._next;
                head1 = head1._next;
            }

            return true;
        }
    }
}
