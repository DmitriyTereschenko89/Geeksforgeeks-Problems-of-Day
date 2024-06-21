namespace Path_With_Minimum_Effort
{
    class Solution
    {
        private class Effort(int row, int col, int maxEffort)
        {
            public int row = row;
            public int col = col;
            public int maxEffort = maxEffort;
        }

        private List<int[]> GetNeighbors(int r, int c, int rows, int columns)
        {
            int[] deltaX = [0, -1, 0, 1];
            int[] deltaY = [-1, 0, 1, 0];
            List<int[]> neighbors = [];
            for (int i = 0; i < 4; ++i)
            {
                int newR = deltaX[i] + r;
                int newC = deltaY[i] + c;
                if (newR >= 0 && newR < rows && newC >= 0 && newC < columns)
                {
                    neighbors.Add([newR, newC]);
                }
            }

            return neighbors;
        }

        public int MinimumEffort(int rows, int columns, int[,] heights)
        {
            int minEffort = int.MaxValue;
            bool[,] visited = new bool[rows, columns];
            Queue<Effort> queue = new();
            queue.Enqueue(new Effort(0, 0, 0));
            while (queue.Count > 0)
            {
                Effort ef = queue.Dequeue();
                if (ef.row == rows - 1 && ef.col == columns - 1)
                {
                    minEffort = Math.Min(minEffort, ef.maxEffort);
                }

                List<int[]> neighbors = GetNeighbors(ef.row, ef.col, rows, columns);
                for (int i = 0; i < neighbors.Count; ++i)
                {
                    int newR = neighbors[i][0];
                    int newC = neighbors[i][1];
                    if (!visited[newR, newC])
                    {
                        visited[newR, newC] = true;
                        int effort = Math.Abs(heights[newR, newC] - heights[ef.row, ef.col]);
                        queue.Enqueue(new Effort(newR, newC, Math.Max(effort, ef.maxEffort)));
                    }
                }
            }

            return minEffort;
        }
    }
}
