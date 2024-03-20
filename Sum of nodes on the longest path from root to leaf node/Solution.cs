using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_nodes_on_the_longest_path_from_root_to_leaf_node
{
	public class Solution
	{
		private (int, int) DFS(Node node, int depth, int pathSum)
		{
			if (node is null)
			{
				return (0, 0);
			}
			if (node.left is null && node.right is null)
			{
				return (depth, pathSum + node.data);
			}
			var (leftDepth, leftPathSum) = DFS(node.left, depth + 1, pathSum + node.data);
			var (rightDepth, rightPathSum) = DFS(node.right, depth + 1, pathSum + node.data);
			if (leftDepth > rightDepth)
			{
				return (leftDepth, leftPathSum);
			}
			else if (rightDepth > leftDepth)
			{
				return (rightDepth, rightPathSum);
			}
			else
			{
				return (leftDepth, Math.Max(leftPathSum, rightPathSum));
			}
		}
		public int SumOfLongRootToLeafPath(Node root)
		{
			var (_, pathSum) = DFS(root, 0, 0);
			return pathSum;
		}
	}
}
