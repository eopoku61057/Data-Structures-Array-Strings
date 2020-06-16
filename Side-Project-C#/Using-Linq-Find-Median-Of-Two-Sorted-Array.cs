using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algorithm
{
    class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] comb = nums1.Concat(nums2).ToArray();
            Array.Sort(comb);
            int mid = comb.Length / 2;

            if (comb.Length % 2 == 0)
            {
                return ((double)(comb[mid] + comb[mid] - 1) / 2);
            }
            else
            {
                return ((double)comb[mid]);
            }
        }

    }
}
