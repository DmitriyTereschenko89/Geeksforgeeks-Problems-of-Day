namespace Kth_common_ancestor_in_BST
{
	public class Solution
	{
		public int KthCommonAncestor(Node root, int k, int x, int y)
		{
			Node node = root;
			List<int> acs = [];
			while (node != null)
			{
				acs.Add(node.data);
				if (node.data > x && node.data > y)
				{
					node = node.left;
				}
				else if (node.data < x && node.data < y)
				{
					node = node.right;
				}
                else
                {
					break;
                }
            }
			if (acs.Count < k)
			{
				return -1;
			}
			return acs[^k];
		}
	}
}
