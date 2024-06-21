using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_an_Extra_Element
{
    internal class Solution
    {
        public int FindExtra(int n, int[] arr1, int[] arr2)
        {
            int start = 0;
            int end = n - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid < n - 1 && arr1[mid] >= arr2[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return start;
        }
    }
}
