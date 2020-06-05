/*
Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

Your algorithm's runtime complexity must be in the order of O(log n).

If the target is not found in the array, return [-1, -1].

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
        public int[] SearchRange(int[] nums, int target)
        {
            // Time Complexity: 0(N)
            // Space Complexity: 0(1)
            int[] targetRange = { -1, -1 };

            // find the index of the leftmost appearance of target
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    targetRange[0] = i;
                    break;
                }
            }

            // if the laost loop did not any index, then there is no valid range and we return [-1, -1]
            if (targetRange[0] == -1)
            {
                return targetRange;
            }

            // find the index of the rightmost appearance of target (by reverse iteration. it is guaranteed to appear
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] == target)
                {
                    targetRange[1] = j;
                    break;
                }
            }

            return targetRange;
        }


    }
}
