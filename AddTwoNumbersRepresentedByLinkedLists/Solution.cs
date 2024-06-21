namespace AddTwoNumbersRepresentedByLinkedLists
{
    internal class Solution
    {
        private Node ReverseList(Node head)
        {
            Node prev = null;
            Node node = head;
            while (node != null)
            {
                Node next = node.next;
                node.next = prev;
                prev = node;
                node = next;
            }

            return prev;
        }

        public Node AddTwoLists(Node num1, Node num2)
        {
            while (num1 != null && num1.data == 0)
            {
                num1 = num1.next;
            }

            while (num2 != null && num2.data == 0)
            { 
                num2 = num2.next;
            }

            Node reversedNum1 = ReverseList(num1);
            Node reversedNum2 = ReverseList(num2);
            Node sumNode = new(0);
            Node node = sumNode;
            int remainder = 0;
            while (reversedNum1 != null || reversedNum2 != null) 
            {
                int data1 = reversedNum1 != null ? reversedNum1.data : 0;
                int data2 = reversedNum2 != null ? reversedNum2.data : 0;
                int sum = data1 + data2 + remainder;
                int curData = sum % 10;
                remainder = sum / 10;
                node.next = new(curData);
                node = node.next;
                reversedNum1 = reversedNum1?.next;
                reversedNum2 = reversedNum2?.next;
            }
            
            if (remainder > 0)
            {
                node.next = new(remainder);
                _ = node.next;
            }

            return ReverseList(sumNode.next);
        }
    }
}
