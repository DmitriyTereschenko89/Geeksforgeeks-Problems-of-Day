namespace Spirally_traversing_a_matrix
{
    using System.Collections.Generic;

    internal class Solution
    {
        public List<int> SpirallyTraverse(int[][] mat)
        {
            int n = mat.Length;
            int m = mat[0].Length;
            int startR = 0;
            int startC = 0;
            int endR = n - 1;
            int endC = m - 1;
            List<int> spiralMat = [];
            while (startR <= endR && startC <= endC)
            {
                for (int i = startR; i <= endC; ++i)
                {
                    spiralMat.Add(mat[startR][i]);
                }

                ++startR;
                for (int i = startR; i <= endR; ++i)
                {
                    spiralMat.Add(mat[i][endC]);
                }

                --endC;
                if (startR <= endR)
                {
                    for (int i = endC; i >= startC; --i)
                    {
                        spiralMat.Add(mat[endR][i]);
                    }
                    --endR;
                }


                if (startC <= endC)
                {
                    for (int i = endR; i >= startR; --i)
                    {
                        spiralMat.Add(mat[i][startC]);
                    }
                    ++startC;
                }

                
            }

            return spiralMat;
        }
    }
}
