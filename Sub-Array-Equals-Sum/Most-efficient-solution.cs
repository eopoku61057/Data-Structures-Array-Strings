using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    {
        public int subarraySum(int[] nums, int k)
        {
            /*
             * Time complexity : O(n) We need to consider every subarray possible.
                Space complexity : O(n). Constant space is used.
             */
            int count = 0;
            int sum = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (map.ContainsKey(sum - k))
                {
                    count += map.GetValueOrDefault(sum - k);
                }
                map.Add(sum, map.GetValueOrDefault(sum, 0) + 1);
            }
            return count;
        }
    }
}
