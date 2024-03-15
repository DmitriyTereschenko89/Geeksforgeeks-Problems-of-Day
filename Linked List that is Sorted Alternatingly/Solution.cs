namespace Linked_List_that_is_Sorted_Alternatingly
{
	public class Solution
	{
		/*Node n1 = head;
        Node n2 = head.next;
        while(n2!=null){
            if(n1.data>n2.data){
                int t=n1.data;
                n1.data=n2.data;
                n2.data=t;
            } 
                n2=n2.next;
        if(n2==null){
                n1=n1.next;
                n2=n1.next;
            }
        }
        return head;*/
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
