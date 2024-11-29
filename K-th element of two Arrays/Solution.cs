namespace K_th_element_of_two_Arrays
{
    internal class Solution
    {
        private int DFS(int[] arr1,  int start1,  int end1, int[] arr2, int start2, int end2, int k)
        {
            if (start1 == end1)
            {
                return arr2[start2 + k];
            }

            if (start2 == end2)
            {
                return arr1[start1 + k];
            }

            int mid1 = (start1 + end1) / 2;
            int mid2 = (start2 + end2) / 2;

            if (mid1  - start1 + mid2 - start2 < k)
            {
                if (arr1[mid1] > arr2[mid2])
                {
                    return DFS(arr1, start1, end1, arr2, mid2 + 1, end2, k - (mid2 - start2) - 1);
                }
                else
                {
                    return DFS(arr1,  mid1 + 1, end1, arr2, start2, end2, k - (mid1 - start1) - 1);
                }
            }
            else
            {
                if (arr1[mid1] > arr2[mid2])
                {
                    return DFS(arr1, start1, mid1, arr2, start2, end2, k);
                }
                else
                {
                    return DFS(arr1, start1, end1, arr2, start2, mid2, k);
                }
            }
        }

        public int KthElement(int k, int[] arr1, int[] arr2)
        {
            k -= 1;
            int start1 = 0;
            int start2 = 0;
            int end1 = arr1.Length;
            int end2 = arr2.Length;
            while (start1 < end1 && start2 < end2)
            {
                int mid1 = (start1 + end1) / 2;
                int mid2 = (start2 + end2) / 2;

                if (mid1 - start1 + mid2 - start2 < k)
                {
                    if (arr1[mid1] > arr2[mid2])
                    {
                        k = k - (mid2 - start2) - 1;
                        start2 = mid2 + 1;                        
                    }
                    else
                    {
                        k = k - (mid1 - start1) - 1;
                        start1 = mid1 + 1;                       
                    }
                }
                else
                {
                    if (arr1[mid1] > arr2[mid2])
                    {
                        end1 = mid1;
                    }
                    else
                    {
                        end2 = mid2;
                    }
                }
            }

            if (start1 == end1)
            {
                return arr2[start2 + k];
            }

            return arr1[start1 + k];
            //return DFS(arr1, 0, arr1.Length, arr2, 0, arr2.Length, k - 1);
        }
    }
}
