namespace Job_Sequencing_Problem
{
    internal class Solution
    {
        public int[] JobScheduling(Job[] arr, int n)
        {
            Array.Sort(arr, (a, b) => b.profit - a.profit);
            bool[] timeLine = new bool[n];
            int jobs = 0;
            int maxProfit = 0;
            for (int i = 0; i < n; ++i)
            {
                int deadline = arr[i].deadline - 1;
                while (deadline > -1)
                {
                    if (!timeLine[deadline])
                    {
                        timeLine[deadline] = true;
                        ++jobs;
                        maxProfit += arr[i].profit;
                        break;
                    }

                    --deadline;
                }
            }

            return [jobs, maxProfit];
        }
    }
}
