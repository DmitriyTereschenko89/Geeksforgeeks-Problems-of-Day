using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersRepresentedByLinkedLists
{
    internal class Node(int data, Node next = null)
    {
        public int data = data;
        public Node next = next;
    }
}
