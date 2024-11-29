namespace Find_the_number_of_islands
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System;

    internal class Solution
    {
        public int BFS(int[][] grid, bool[][] visited, int r, int c, int n, int m)
        {
            int[] delta_x = [0, -1, -1, -1, 0, 1, 1, 1];
            int[] delta_y = [-1, -1, 0, 1, 1, 1, 0, -1];
            Queue<(int, int)> queue = [];
            queue.Enqueue((r, c));
            while (queue.Count > 0)
            {
                var (cur_r, cur_c) = queue.Dequeue();
                for (int i = 0; i < 8; ++i)
                {
                    int new_r = cur_r + delta_x[i];
                    int new_c = cur_c + delta_y[i];
                    if (new_r >= 0 && new_r < n && new_c >= 0 && new_c < m && !visited[new_r][new_c] && grid[new_r][new_c] == 1)
                    {
                        visited[new_r][new_c] = true;
                        queue.Enqueue((new_r, new_c));
                    }
                }
            }

            //foreach (int[] row in grid)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}

            //Console.WriteLine(new string('=', 20));
            //foreach (bool[] row in visited)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}

            return 1;
        }


        public int NumIslands(int[][] grid)
        {
            int islands = 0;
            int n = grid.Length;
            int m = grid[0].Length;
            bool[][] visited = new bool[n][];
            for (int i = 0; i < n; ++i)
            {
                visited[i] = new bool[m];
            }

            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < m; ++c)
                {
                    if (grid[r][c] == 1 && !visited[r][c])
                    {
                        islands += BFS(grid, visited, r, c, n, m);
                    }
                }
            }

            return islands;
        }
    }
}
