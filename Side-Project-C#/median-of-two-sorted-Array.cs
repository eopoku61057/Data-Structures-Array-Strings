using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{
    class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                FindMedianSortedArrays(nums2, nums1);
            }
            int lengthA = nums1.Length;
            int lengthB = nums2.Length;

            int lo = 0, hi = lengthA;
            while (lo <= hi)
            {
                // start partitions
                int partitionA = (lo + hi) / 2;
                int partitionB = (lengthA + lengthB + 1) / 2 - partitionA;

                int maxLeftA = partitionA == 0 ? int.MinValue : nums1[partitionA - 1];
                int minRightA = partitionA == 0 ? int.MaxValue : nums1[partitionA];

                int maxLeftB = partitionB == 0 ? int.MinValue : nums2[partitionB - 1];
                int minRightB = partitionB == 0 ? int.MaxValue : nums2[partitionB];

                if (maxLeftA <= maxLeftB && minRightA <= minRightB)
                {
                    // if it's even
                    if ((lengthA + lengthB) / 2 == 0)
                    {
                        return ((double)Math.Max(maxLeftA, maxLeftB) + Math.Max(minRightA, minRightB)) / 2;
                    }
                    else // if is old
                    {
                        return ((double)Math.Max(maxLeftA, maxLeftB));
                    }
                }
                else if (maxLeftA > minRightB)
                {
                    hi = partitionA - 1;
                }
                else
                {
                    lo = partitionA + 1;
                }
            }
            return new double();
        }

        static void Main(string[] args)
        {
            Solution sb = new Solution();
            int[] d = { 1, 2 };
            int[] dd = { 3, 4 };
            double mid = sb.FindMedianSortedArrays(d, dd);
            Console.Write(mid + " ");

        }

    }
}
