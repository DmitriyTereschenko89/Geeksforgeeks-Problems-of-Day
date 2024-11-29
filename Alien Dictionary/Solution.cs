namespace Alien_Dictionary
{
    internal class Solution
    {
        private Dictionary<char, int> FindInorders(Dictionary<char, HashSet<char>> graph)
        {
            Dictionary<char, int> inorders = [];
            foreach (var node in graph.Keys)
            {
                inorders[node] = 0;
            }

            foreach (var node in graph.Keys)
            {
                foreach (var item in graph[node])
                {
                    inorders[item] += 1;
                }
            }

            return inorders;
        }

        private List<char> TopologicalSort(Dictionary<char, HashSet<char>> graph)
        {
            List<char> topologicalSort = [];
            MinHeap heap = new();
            Dictionary<char, int> inorders = FindInorders(graph);
            foreach (var node in graph.Keys)
            {
                if (inorders[node] == 0)
                {
                    heap.Push(node);
                }
            }

            while (!heap.IsEmpty())
            {
                char node = heap.Pop();
                topologicalSort.Add(node);
                foreach (var neighbor in graph[node])
                {
                    --inorders[neighbor];
                    if (inorders[neighbor] == 0)
                    {
                        heap.Push(neighbor);
                    }
                }
            }

            foreach (var indegree in inorders.Values)
            {
                if (indegree != 0)
                {
                    return [];
                }
            }

            return topologicalSort;
        }

        public string FindOrder(string[] dict, int n, int k)
        {
            Dictionary<char, HashSet<char>> graph = [];
            foreach (var word in dict)
            {
                for (int i = 0; i < word.Length; ++i)
                {
                    if (!graph.ContainsKey(word[i]))
                    {
                        graph[word[i]] = [];
                    }
                }
            }

            string prevWord = dict[0];
            for (int i = 1; i < n; ++i)
            {
                string curWord = dict[i];
                for (int j = 0; j < prevWord.Length && j < curWord.Length; ++j)
                {
                    if (prevWord[j] != curWord[j])
                    {
                        if (!graph[prevWord[j]].Contains(curWord[j]))
                        {
                            graph[prevWord[j]].Add(curWord[j]);
                            break;
                        }                        
                    }
                }

                prevWord = curWord;
            }

            List<char> topologicalSort = TopologicalSort(graph);

            return topologicalSort.Count < k ? string.Empty : string.Join("", topologicalSort);
        }
    }
}
