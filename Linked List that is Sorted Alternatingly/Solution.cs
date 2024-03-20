namespace Linked_List_that_is_Sorted_Alternatingly
{
	public class Solution
	{
		public Node Sort(Node head)
		{
			Node node1 = head;
			Node node2 = head.next;
			while (node2 != null)
			{
				if (node1.data > node2.data)
				{
					(node1.data, node2.data) = (node2.data, node1.data);
					
				}
				node2 = node2.next;
				if (node2 is null)
				{
					node1 = node1.next;
					node2 = node1.next;
				}
			}
			return head;
		}
	}
}
