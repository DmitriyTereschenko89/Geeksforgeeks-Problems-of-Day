namespace Minimum_Cost_Path
{
    internal class Solution
    {
        public int MinimumCostPath(int[][] grid)
        {
            int n = grid.Length;
            (int, int)[] directions = [(0, -1), (-1, 0), (0, 1), (1, 0)];
            int[][] distances = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                distances[i] = new int[n];
                Array.Fill(distances[i], int.MaxValue);
            }
            
            MinHeap heap = new();
            heap.Push(0, 0, grid[0][0]);
            distances[0][0] = grid[0][0];
            while (!heap.IsEmpty())
            {
                var (row, col, dst) = heap.Pop();
                if (distances[row][col] < dst)
                {
                    continue;
                }

                foreach (var (r ,c ) in directions)
                {
                    int newR = row + r;
                    int newC = col + c;
                    if (newR >= 0 && newR < n && newC >= 0 && newC < n)
                    {
                        int newDst = dst + grid[newR][newC];
                        if (newDst < distances[newR][newC])
                        {
                            distances[newR][newC] = newDst;
                            heap.Push(newR, newC, newDst);
                        }
                    }
                }
                
            }

            return distances[n - 1][n - 1];
        }
    }
}
