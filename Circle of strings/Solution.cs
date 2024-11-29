namespace Circle_of_strings
{
    internal class Solution
    {
        public int IsCircle(string[] arr)
        {
            Dictionary<int, List<int>> adj = [];

            int[] indegree = new int[26];
            int[] outdegree = new int[26];
            foreach (string word in arr)
            {
                if (!adj.ContainsKey(word[0] - 'a'))
                {
                    adj[word[0] - 'a'] = [];
                }

                adj[word[0] - 'a'].Add(word[^1] - 'a');
                ++indegree[word[0] - 'a'];
                ++outdegree[word[^1] - 'a'];
            }

            for (int i = 0; i < 26; ++i)
            {
                if (indegree[i] != outdegree[i])
                {
                    return 0;
                }
            }

            Stack<int> st = [];
            HashSet<int> visited = [];
            st.Push(arr[0][0] - 'a');
            while (st.Count > 0)
            {
                int node = st.Pop();
                
                if (adj.TryGetValue(node, out var neighbors))
                {
                    foreach (var neighbor in neighbors)
                    {
                        if (visited.Contains(neighbor))
                        {
                            continue;
                        }

                        visited.Add(neighbor);
                        st.Push(neighbor);
                    }
                }
            }

            return visited.Count == adj.Count ? 1 : 0;
        }
    }
}
