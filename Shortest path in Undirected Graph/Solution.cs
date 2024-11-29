namespace Shortest_path_in_Undirected_Graph
{
    internal class Solution
    {
        private void DijkstrasAlgorithm(List<(int, int)>[] adj, int[] distances, int src)
        {
            MinHeap heap = new();
            distances[src] = 0;
            heap.Push(src, 0);
            while (!heap.IsEmpty())
            {
                var (node, distance) = heap.Pop();
                if (distance == int.MaxValue)
                {
                    continue;
                }

                foreach (var (neighbor, dst) in adj[node])
                {
                    if (distance + dst < distances[neighbor])
                    {
                        distances[neighbor] = distance + dst;
                        heap.Push(neighbor, distance + dst);
                    }
                }
            }
        }

        public int[] ShortestPath(int[][] edges, int n, int m, int src)
        {
            List<(int, int)>[] adj = new List<(int, int)>[n];
            for (int i = 0; i < n; ++i)
            {
                adj[i] = [];
            }
            int[] distances = new int[n];
            Array.Fill(distances, int.MaxValue);
            for (int i = 0; i < m; ++i)
            {
                int u = edges[i][0];
                int v = edges[i][1];
                adj[u].Add((v, 1));
                adj[v].Add((u, 1));
            }

            DijkstrasAlgorithm(adj, distances, src);
            for (int i = 0; i < n; ++i)
            {
                if (distances[i] == int.MaxValue)
                {
                    distances[i] = -1;
                }
            }

            return distances;
        }
    }
}
