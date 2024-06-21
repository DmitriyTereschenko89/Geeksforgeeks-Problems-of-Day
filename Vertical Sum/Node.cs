using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertical_Sum
{
    internal class Node(int data, Node left = null, Node right = null)
    {
        public int _data = data;
        public Node _left = left;
        public Node _right = right;
    }
}
