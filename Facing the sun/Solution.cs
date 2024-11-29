namespace Facing_the_sun
{
    internal class Solution
    {
        public int CountBuildings(int[] height)
        {
            int ans = 0;
            int maxHeight = int.MinValue;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > maxHeight)
                {
                    maxHeight = height[i];
                    ans++;
                }
            }

            return ans;
        }
    }
}
