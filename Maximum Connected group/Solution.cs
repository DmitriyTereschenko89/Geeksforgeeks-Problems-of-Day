namespace Maximum_Connected_group
{
    internal class Solution
    {
        private int DFS(int[][] grid, bool[][] visited, int r, int c, int key)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid.Length || visited[r][c] || grid[r][c] == 0)
            {
                return 0;
            }

            visited[r][c] = true;
            int size = 1 + DFS(grid, visited, r + 1, c, key) + DFS(grid, visited, r - 1, c, key) + DFS(grid, visited, r, c + 1, key) + DFS(grid, visited, r, c - 1, key);
            grid[r][c] = key;

            return size;
        }

        private List<int> GetNeighbors(int[][] grid, int r, int c)
        {
            List<int> neighbors = [];
            int[] deltaX = [0, -1, 0, 1];
            int[] deltaY = [-1, 0, 1, 0];
            for (int i = 0; i < 4; ++i)
            {
                int newR = r + deltaX[i];
                int newC = c + deltaY[i];
                if (newR >= 0 && newR < grid.Length && newC >= 0 && newC < grid.Length)
                {
                    neighbors.Add(grid[newR][newC]);
                }
            }
            
            return neighbors;
        }
        
        public int MaxConnection(int[][] grid)
        {
            int maxConnection = -1;
            int key = 2;
            int n = grid.Length;
            bool[][] visited = new bool[n][];
            Dictionary<int, int> map = [];
            for (int i = 0; i < n; ++i)
            {
                visited[i] = new bool[n];
            }

            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < n; ++c)
                {
                    if (!visited[r][c] && grid[r][c] == 1)
                    {
                        int size = DFS(grid, visited, r, c, key);
                        map[key] = size;
                        ++key;
                    }
                }
            }

            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < n; ++c)
                {
                    if (grid[r][c] == 0)
                    {
                        int currentSize = 1;
                        List<int> neighbors = GetNeighbors(grid, r, c);
                        HashSet<int> set = new HashSet<int>(neighbors);
                        foreach (int neighbor in set)
                        {
                            if (map.TryGetValue(neighbor, out int value))
                            {
                                currentSize += value;
                            }
                        }

                        maxConnection = Math.Max(maxConnection, currentSize);
                    }
                }
            }

            if (maxConnection == -1)
            {
                return n * n;
            }

            return maxConnection;
        }
    }
}
