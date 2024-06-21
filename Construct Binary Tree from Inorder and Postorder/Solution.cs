namespace Construct_Binary_Tree_from_Inorder_and_Postorder
{
    public class Solution
    {
        private int postIndex;

        private TreeNode CreateTree(Dictionary<int, int> inorderMap, int[] inorder, int[] postorder, int leftIdx, int rightIdx)
        {
            if (leftIdx > rightIdx)
            {
                return null;
            }

            int data = postorder[postIndex--];
            int inorderIdx = inorderMap[data];
            TreeNode node = new(data);
            node.right = CreateTree(inorderMap, inorder, postorder, inorderIdx + 1, rightIdx);
            node.left = CreateTree(inorderMap, inorder, postorder, leftIdx, inorderIdx - 1);
            return node;

        }
        //Definition for a binary tree node.
        public class TreeNode(int x)
        {
            public int val = x;
            public TreeNode left = null;
            public TreeNode right = null;
        }

        //Function to return a tree created from postorder and inorder traversals.
        public TreeNode BuildTree(int[] inorder, int[] postorder, int n)
        {
            postIndex = n - 1;
            Dictionary<int, int> inorderMap = [];
            for (int i = 0; i < n; ++i)
            {
                inorderMap.Add(inorder[i], i);
            }

            return CreateTree(inorderMap, inorder, postorder, 0, n - 1);
        }
    }
}
