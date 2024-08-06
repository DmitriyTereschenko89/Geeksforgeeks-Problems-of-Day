namespace Rat_in_a_Maze_Problem___I
{
    internal class Solution
    {
        private readonly (int, int, char)[] _directions = [(0, -1, 'L'), (-1, 0, 'U'), (0, 1, 'R'), (1, 0, 'D')];
        private readonly int _direction = 4;

        private void DFS(List<string> paths, List<char> curPath, int[][] matrix, bool[][] visited, int curR, int curC)
        {
            if (curR < 0 || curC < 0 || curR >= matrix.Length || curC >= matrix[curR].Length || matrix[curR][curC] == 0 || visited[curR][curC])
            {
                return;
            }

            if (curR == matrix.Length - 1 && curC == matrix[curR].Length - 1)
            {
                paths.Add(string.Join("", curPath));
                return;
            }

            visited[curR][curC] = true;
            for (int d = 0; d < _direction; ++d)
            {
                var (nextR, nextC, dir) = _directions[d];
                curPath.Add(dir);
                DFS(paths, curPath, matrix, visited, nextR + curR, nextC + curC);
                curPath.RemoveAt(curPath.Count - 1);
            }

            visited[curR][curC] = false;
        }

        public IEnumerable<string> FindPath(int[][] matrix)
        {
            List<string> paths = [];
            bool[][] visited = new bool[matrix.Length][];
            for (int i = 0; i < matrix.Length; ++i)
            {
                visited[i] = new bool[matrix[i].Length];
            }

            DFS(paths, [], matrix, visited, 0, 0);
            return paths;
        }
    }
}
