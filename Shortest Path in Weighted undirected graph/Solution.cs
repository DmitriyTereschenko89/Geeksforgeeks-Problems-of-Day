namespace Shortest_Path_in_Weighted_undirected_graph
{
    using System.Collections.Generic;

    internal class Solution
    {
        public List<int> ShortestPath(int n, int m, int[][] edges)
        {
            int[] distances = new int[n + 1];
            int[] parent = new int[n + 1];
            List<Node>[] adj = new List<Node>[n + 1];
            Array.Fill(distances, int.MaxValue);
            for (int i = 0; i <= n; ++i)
            {
                adj[i] = [];
                parent[i] = i;
            }

            for (int i = 0; i < m; ++i)
            {
                int v = edges[i][0];
                int u = edges[i][1];
                int weight = edges[i][2];
                adj[v].Add(new Node(u, weight));
                adj[u].Add(new Node(v, weight));
            }

            distances[1] = 0;
            MinHeap heap = new();
            heap.Push(1, 0);
            while (!heap.IsEmpty())
            {
                Node curNode = heap.Pop();
                int vertex = curNode._node;
                int distance = curNode._distance;
                foreach (Node neighbor in adj[vertex])
                {
                    int adjNode = neighbor._node;
                    int weight = neighbor._distance;
                    if (distance + weight < distances[adjNode])
                    {
                        distances[adjNode] = distance + weight;
                        heap.Push(adjNode, distance + weight);
                        parent[adjNode] = vertex;
                    }
                }
            }

            List<int> path = [];
            if (distances[n] == int.MaxValue)
            {
                path.Add(-1);
                return path;
            }

            int node = n;
            while (parent[node] != node)
            {
                path.Add(node);
                node = parent[node];
            }

            path.Add(1);
            path.Add(distances[n]);
            path.Reverse();

            return path;
        }
    }
}
