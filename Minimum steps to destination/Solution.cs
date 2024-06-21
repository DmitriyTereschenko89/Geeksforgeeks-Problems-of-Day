namespace Minimum_steps_to_destination
{
    internal class Solution
    {
        public int MinSteps(int d)
        {
            for (int i = 1; i < 2 * d; ++i)
            {
                if (((i * (i + 1)) / 2 + d) % 2 == 0 && ((i * (i + 1)) / 2) >= d)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
