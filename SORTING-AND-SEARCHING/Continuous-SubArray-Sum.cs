/*
Given a list of non-negative numbers and a target integer k, write a function to check if the array has a continuous subarray of size at least 2 that sums up to a multiple of k, 
that is, sums up to n*k where n is also an integer.
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
        // Time complexity: 0(N)
        // Space Complexity: 0(1)
        public Boolean checkSubarraySum(int[] nums, int k)
        {
            if (nums.Length == null) return false;
            int sum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                for ( int j = i + 1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];
                    if (k == sum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
