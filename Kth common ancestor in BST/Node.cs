using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_common_ancestor_in_BST
{
	public class Node(int data = 0, Node left = null, Node right = null)
	{
		public int data = data;
		public Node left = left;
		public Node right = right;
	}
}
