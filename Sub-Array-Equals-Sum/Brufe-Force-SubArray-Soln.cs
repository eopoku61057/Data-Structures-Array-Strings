using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    { // time complexity =0(n^3)  space complexity 0(1)
        public int subarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int start = 0; start < nums.Length; start++)
            {
                for (int end = start + 1; end <= nums.Length; end++)
                {
                    int sum = 0;
                    for (int i = start; i < end; i++)
                    {
                        sum += nums[i];
                        if (sum == k)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
