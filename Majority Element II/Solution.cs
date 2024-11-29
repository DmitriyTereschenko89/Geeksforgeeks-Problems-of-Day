namespace Majority_Element_II
{
    internal class Solution
    {
        private static bool IsMajority(List<int> nums, int candidate, int target)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num == candidate)
                {
                    ++count;
                }
            }

            return count > target;
        }

        public static List<int> FindMajority(List<int> nums)
        {
            List<int> majorities = [];
            int firstCandidate = -1;
            int count = 0;
            for (int i = 0; i < nums.Count; ++i)
            {
                if (count == 0)
                {
                    firstCandidate = nums[i];
                    count = 1;
                }
                else
                {
                    if (firstCandidate == nums[i])
                    {
                        ++count;
                    }
                    else
                    {
                        --count;
                    }
                }
            }

            if (IsMajority(nums, firstCandidate, nums.Count / 3))
            {
                majorities.Add(firstCandidate);
            }

            int secondCandidate = -1;
            count = 0;
            for (int i = 0; i < nums.Count; ++i)
            {
                if (nums[i] == firstCandidate)
                {
                    continue;
                }

                if (count == 0)
                {
                    secondCandidate = nums[i];
                    count = 1;
                }
                else
                {
                    if (secondCandidate == nums[i])
                    {
                        ++count;
                    }
                    else
                    {
                        --count;
                    }
                }
            }

            if (IsMajority(nums, secondCandidate, nums.Count / 3))
            {
                majorities.Add(secondCandidate);                
            }

            majorities.Sort();

            return majorities;

        }
    }
}
