namespace Construct_Binary_Tree_from_Parent_Array
{
    internal class Solution
    {
        public Node CreateTree(int[] parent)
        {
            int n = parent.Length;
            Node[] nodes = new Node[n];
            for (int i = 0; i < n; ++i)
            {
                nodes[i] = new Node(i);
            }

            Node root = null;
            for (int i = 0; i < n; ++i)
            {
                if (parent[i] == -1)
                {
                    root = nodes[i];
                }
                else
                {
                    Node curParent = nodes[parent[i]];
                    if (curParent.left is null)
                    {
                        curParent.left = nodes[i];
                    }
                    else
                    {
                        curParent.right = nodes[i];
                    }
                }
            }

            return root;
        }
    }
}
