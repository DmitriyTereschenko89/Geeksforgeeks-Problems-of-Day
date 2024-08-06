namespace Row_with_max_1s
{
    internal class Solution
    {
        public int RowWithMax1s(int[][] arr)
        {
            int maxOneCount = 0;
            int maxRowIdx = -1;
            int r = 0;
            int n = arr.Length;
            int m = arr[0].Length;
            int c = arr[0].Length - 1;
            while ((c > -1 && r > -1) && (c < m && r < n))
            {
                if (arr[r][c] == 0)
                {
                    ++r;
                }
                else
                {
                    if (maxOneCount < m - c)
                    {
                        maxOneCount = m - c;
                        maxRowIdx = r;
                    }

                    --c;
                }

                
            }

            return maxRowIdx;
        }
    }
}
