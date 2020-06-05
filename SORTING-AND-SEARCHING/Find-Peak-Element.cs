/*
    A peak element is an element that is greater than its neighbors.
    Given an input array nums, where nums[i] ≠ nums[i+1], find a peak element and return its index.
    The array may contain multiple peaks, in that case return the index to any one of the peaks is fine.
    You may imagine that nums[-1] = nums[n] = -∞.
 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public int FindpeakElement(int[] nums)
        {
            // Time complexity: 0(log2 (N))
            // Space complexity: 0(1)
            int i = 0, r = nums.Length - 1;
            while (i < r)
            {
                int mid = (i + r) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    r = mid;
                }
                else
                {
                    i = mid + 1;
                }
            }

            return i;
        }
    }
}
