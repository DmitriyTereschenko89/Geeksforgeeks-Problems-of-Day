namespace Prime_Pair_with_Target_Sum
{
    internal class Solution
    {
        private List<int> Primes(int n)
        {
            List<int> ans = [];
            int k = (n - 1) / 2;
            bool[] primes = new bool[k + 1];
            Array.Fill(primes, true);
            for (int i = 1; i * i <= k; ++i)
            {
                int j = i;
                while (i + j + 2 * i * j <= k)
                {
                    primes[i + j + 2 * i * j] = false;
                    ++j;
                }
            }

            if (n >= 2)
            {
                ans.Add(2);
            }

            for (int i = 1; i <= k; ++i)
            {
                if (primes[i])
                {
                    ans.Add(2 * i + 1);
                }
            }

            return ans;
        }
        public List<int> GetPrimes(int n)
        {
            List<int> ans = [-1, -1];
            List<int> primes = Primes(n);
            int start = 0;
            int end = primes.Count - 1;
            while (start <= end)
            {
                int sum = primes[start] + primes[end];
                if (sum == n)
                {
                    if (ans[0] == -1)
                    {
                        ans[0] = primes[start];
                        ans[1] = primes[end];
                    }
                    else
                    {
                        if (primes[start] < primes[end])
                        {
                            if (primes[end] - primes[start] > ans[1] - ans[0])
                            {
                                ans[0] = primes[start];
                                ans[1] = primes[end];
                            }
                        }
                    }

                    ++start;
                    --end;
                }
                else if (sum > n)
                {
                    --end;
                }
                else
                {
                    ++start;
                }
            }

            return ans;
        }
    }
}
