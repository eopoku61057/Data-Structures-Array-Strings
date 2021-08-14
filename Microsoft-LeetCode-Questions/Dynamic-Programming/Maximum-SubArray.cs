using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int ret = MaxSubArray(nums);
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int currentSubArray = nums[0];
            int maxSubArray = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                currentSubArray = Math.Max(num, currentSubArray + num);
                maxSubArray = Math.Max(maxSubArray, currentSubArray);
            }
            return maxSubArray;
        }
    }
}


