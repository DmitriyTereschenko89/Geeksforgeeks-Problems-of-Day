namespace N_meetings_in_one_room
{
    using System;

    internal class Solution
    {
        public int MaxMeetings(int n, int[] start, int[] end)
        {
            int[][] meetings = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                meetings[i] = [start[i], end[i]];
            }

            Array.Sort(meetings, (a, b) => a[1] - b[1]);
            int maxMeetings = 1;
            int prevMeetingEnd = meetings[0][1];
            for (int i = 1; i < n; ++i)
            {
                if (meetings[i][0] > prevMeetingEnd)
                {
                    prevMeetingEnd = meetings[i][1];
                    ++maxMeetings;
                }
            }

            return maxMeetings;
        }
    }
}
