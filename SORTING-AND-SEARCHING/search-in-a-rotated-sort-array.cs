using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public int Search(int[] nums, int target)
        {
            // time Complexity: 0(log N)
            // Space complexity: 0(1)
            int n = nums.Length - 1;
            if (n == null)
            {
                return -1;
            }
            // find the pivot
            int hi = 0, lo = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i + 1] < nums[i])
                {
                    lo = i + 1;
                    hi = i;
                }
            }

            if (target == nums[lo])
            {
                return lo;
            }
            else if (target == nums[hi])
            {
                return hi;
            }

            // find the range of interviews
            // R = start: 0 to hi, L start:lo to size - 1
            
            int start = 0;
            if(target >= nums[start] && target <= nums[hi])
            {
                // divide and search on left side
                return BinarySearch(nums, target, start, hi);
            }
            else if (target >= nums[lo] && target <= nums[n])
            {
                // divde and search the right side
                return BinarySearch(nums, target, lo, n);
            }
            return -1;
        }

        private int BinarySearch(int[] nums, int target, int start, int hi)
        {
            // find the median
            int m = (hi - start + 1) / 2;

            if (m == hi)
            {
                return m;
            }
            
            
            // find the ranges 
            // L = start: 0 to m && R = start: m + 1 to nums.length - 1;

            if (target >= start && target <= nums[m])
            {
                return BinarySearch(nums, target, start, m);
            }
            else if (target >= nums[m + 1] && target <= nums[nums.Length - 1])
            {
                return BinarySearch(nums, target, m + 1, nums.Length - 1);
            }

            return -1;
        }
    }
}
