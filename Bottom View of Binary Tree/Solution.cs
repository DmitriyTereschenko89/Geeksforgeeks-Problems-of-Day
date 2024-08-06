namespace Bottom_View_of_Binary_Tree
{
    using System.Collections.Generic;

    internal class Solution
    {
        public List<int> BottomView(Node root)
        {
            if (root is null)
            {
                return [];
            }

            Queue<(Node, int)> queue = [];
            queue.Enqueue((root, 0));
            SortedDictionary<int, int> horizontalMap = [];
            queue.Enqueue((root, 0));
            while (queue.Count > 0)
            {
                var (node, horizontal) = queue.Dequeue();
                horizontalMap[horizontal] = node.data;
                if (node.left != null)
                {
                    queue.Enqueue((node.left, horizontal - 1));
                }

                if (node.right != null)
                {
                    queue.Enqueue((node.right, horizontal + 1));
                }
            }

            return [.. horizontalMap.Values];
        }
    }
}
