namespace Binary_Tree_to_DLL
{
    internal class Solution
    {
        public Node BToDLL(Node root)
        {
            Node head = null;
            Node tail = null;
            Node cur = root;
            while (cur != null)
            {
                if (cur._left == null)
                {
                    Console.WriteLine(cur._val);
                    if (head == null)
                    {
                        head = tail = cur;
                    }
                    else
                    {
                        tail._right = cur;
                        cur._left = tail;
                        tail = cur;
                    }

                    cur = cur._right;
                }
                else
                {
                    Node predcessor = cur._left;
                    while (predcessor._right != null && predcessor._right != cur)
                    {
                        predcessor = predcessor._right;
                    }

                    if (predcessor._right == null)
                    {
                        predcessor._right = cur;
                        cur = cur._left;
                    }
                    else
                    {
                        predcessor._right = null;
                        Console.WriteLine(cur._val);
                        if (head == null)
                        {
                            head = tail = cur;
                        }
                        else
                        {
                            tail._right = cur;
                            cur._left = tail;
                            tail = cur;
                        }
                        cur = cur._right;
                    }
                }
            }

            return head;
        }
    }
}
