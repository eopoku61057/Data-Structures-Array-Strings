/*
    Given a list of non-negative numbers and a target integer k, write a function to check if 
    the array has a continuous subarray of size at least 2 that sums up to a multiple of k, that is, sums up to n*k where n is also an integer.
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
        public Boolean CheckSubArraySum(int[] nums, int k)
        {
            if (nums.Length == null) return false;

            int sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(k != 0)
                {
                    sum = sum % k;
                }
                if (map.ContainsKey(sum))
                {
                    if(i - map.GetValueOrDefault(sum) > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    map.Add(sum, i);
                }
            }
            return false;
        }
    }
}
