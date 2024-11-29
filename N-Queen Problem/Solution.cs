namespace N_Queen_Problem
{
    using System.Text;

    internal class Solution
    {
        public List<List<int>> SolveNQueens(int n)
        {
            List<List<int>> positions = [];
            int[] curCols = new int[n];
            Array.Fill(curCols, -1);
            HashSet<int> blockedCol = [];
            HashSet<int> blockedUpDiagonal = [];
            HashSet<int> blockedDownDiagonal = [];
            SolveNQueens(n, 0, blockedCol, blockedUpDiagonal, blockedDownDiagonal, positions, curCols);
            return positions;
        }

        private void SolveNQueens(int row, int currentRow, HashSet<int> blockedCol, HashSet<int> blockedUpDiagonal, HashSet<int> blockedDownDiagonal, List<List<int>> positions, int[] curCols)
        {
            if (currentRow == row)
            {
                positions.Add(new List<int>(curCols));
            }
            for (int col = 0; col < row; col++)
            {
                if (IsValidPosition(currentRow, col, blockedCol, blockedUpDiagonal, blockedDownDiagonal))
                {
                    AddQueen(currentRow, col, blockedCol, blockedUpDiagonal, blockedDownDiagonal, curCols);
                    SolveNQueens(row, currentRow + 1, blockedCol, blockedUpDiagonal, blockedDownDiagonal, positions, curCols);
                    RemoveQueen(currentRow, col, blockedCol, blockedUpDiagonal, blockedDownDiagonal, curCols);
                }
            }
        }

        //private void ReconstructPositions(int row, HashSet<int> blockedCol, List<string[]> positions)
        //{
        //    string[] curPosition = new string[row];
        //    int posIdx = 0;
        //    foreach (var col in blockedCol)
        //    {
        //        StringBuilder rowQueen = new StringBuilder();
        //        for (int colIdx = 0; colIdx < row; colIdx++)
        //        {
        //            if (colIdx != col)
        //            {
        //                rowQueen.Append(".");
        //            }
        //            else
        //            {
        //                rowQueen.Append("Q");
        //            }
        //        }
        //        curPosition[posIdx++] = rowQueen.ToString();
        //    }
        //    positions.Add(curPosition);
        //}

        private bool IsValidPosition(int row, int col, HashSet<int> blockedCol, HashSet<int> blockedUpDiagonal, HashSet<int> blockedDownDiagonal)
        {
            if (blockedCol.Contains(col))
            {
                return false;
            }

            if (blockedUpDiagonal.Contains(row - col))
            {
                return false;
            }

            if (blockedDownDiagonal.Contains(row + col))
            {
                return false;
            }

            return true;
        }

        private void AddQueen(int row, int col, HashSet<int> blockedCol, HashSet<int> blockedUpDiagonal, HashSet<int> blockedDownDiagonal, int[] curCols)
        {
            blockedCol.Add(col);
            blockedUpDiagonal.Add(row - col);
            blockedDownDiagonal.Add(row + col);
            curCols[row] = col + 1;
        }

        private void RemoveQueen(int row, int col, HashSet<int> blockedCol, HashSet<int> blockedUpDiagonal, HashSet<int> blockedDownDiagonal, int[] curCols)
        {
            blockedCol.Remove(col);
            blockedUpDiagonal.Remove(row - col);
            blockedDownDiagonal.Remove(row + col);
            curCols[row] = -1;
        }
    }
}
