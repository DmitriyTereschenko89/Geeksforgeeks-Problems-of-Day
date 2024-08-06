namespace The_Celebrity_Problem
{
    internal class Solution
    {
        public int Celebrity(int[][] mat)
        {
            int n = mat.Length;
            for (int r = 0; r < n; ++r)
            {
                int x = 0;
                int y = 0;
                for (int c = 0; c < n; ++c)
                {
                    if (mat[r][c] == 1)
                    {
                        ++x;  
                    }

                    if (mat[c][r] == 1)
                    {
                        ++y;
                    }
                }

                if (x == 0 && y == n - 1)
                {
                    return r;
                }
            }

            return -1;
        }
    }
}
