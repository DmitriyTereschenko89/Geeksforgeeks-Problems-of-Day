namespace Vertical_Sum
{
    internal class Solution
    {
        private void DFS(Node node, SortedDictionary<int, int> vMap, int verticalLevel)
        {
            if (node is null)
            {
                return;
            }

            vMap[verticalLevel] = vMap.GetValueOrDefault(verticalLevel, 0) + node._data;
            DFS(node._left, vMap, verticalLevel - 1);
            DFS(node._right, vMap, verticalLevel + 1);
        }

        public List<int> VerticalSum(Node root)
        {
            SortedDictionary<int, int> vMap = [];
            DFS(root, vMap, 0);
            return [..vMap.Values];
        }
    }
}
