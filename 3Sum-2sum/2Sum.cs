using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{
    class Solution
    {
        /* Implement two sum */
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 0)
                return new int[2];

            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int data = target - nums[i];
                if (map.ContainsKey(data))
                {
                    return new int[2] { map[data], i };
                }
                else if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            return new int[2];
        }

        static void Main(string[] args)
        {
            Solution sb = new Solution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 17;
            int[] data = sb.TwoSum(nums, target);

            foreach (int i in data)
            {
                Console.Write(i + " ");
            }

        }
    }
}
