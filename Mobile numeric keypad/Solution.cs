namespace Mobile_numeric_keypad
{
    internal class Solution
    {
        public long GetCount(int n)
        {
            List<int>[] adj =
            [
                [0, 8],
                [1, 2, 4],
                [1, 2, 3, 5],
                [2, 3, 6],
                [1, 4, 5, 7],
                [2, 4, 5, 6, 8],
                [3, 5, 6, 9],
                [4, 7, 8],
                [5, 7, 8, 9, 0],
                [6, 8, 9]
            ];


            long[] prev = new long[10];
            Array.Fill(prev, 1);
            for (int i = 2; i <= n; ++i)
            {
                long[] curr = new long[10];
                //Array.Fill(curr, 1);
                for (int j = 0; j < 10; ++j)
                {
                    long total = 0;
                    foreach (int neighbor in adj[j])
                    {
                        total += prev[neighbor];
                    }

                    curr[j] = total;
                }

                prev = curr;
            }

            long count = 0;
            for (int i = 0; i < 10; ++i)
            {
                count += prev[i];
            }

            return count;
        }
    }
}
