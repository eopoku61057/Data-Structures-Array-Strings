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
        // Space Complexity: 0(n, k)
        public Boolean checkSubarraySum(int[] nums, int k)
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
                if(map.ContainsKey(sum))
                {
                    if(i - map.GetValueOrDefault(sum) > 1)
                    {
                        return true;
                    }
                    else
                    {
                        map.Add(sum, i);
                    }
                }
            }
            return false;
        }
    }
}
