using System;
using System.Collections.Generic;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 2, 0, 2, 1, 4, 3, 1, 0};

            LongestSubArray(nums);

        }
        /* Find the largest SubArray formed by consective Intergers
            eg { 2, 0, 2, 1, 4, 3, 1, 0}

            ans: {0, 2, 1, 4, 3}  length: 5, start: index[1] to index[5]
        */

        public static void LongestSubArray(int[] nums)
        {
            int start = 0, end = 0, len = 1;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                int max = nums[i], min = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    max = Math.Max(max, nums[j]);
                    min = Math.Min(min, nums[j]);

                    if(CheckDuplicate(nums, i, j, min, max))
                    {
                        if (len < j - i + 1)
                        {
                            start = i;
                            end = j;
                            len = j - i + 1;
                        }
                        
                    }
                }
            }

            Console.Write(start + ".... " + end);
            Console.WriteLine();
            Console.Write(len + " ");
        }

        private static bool CheckDuplicate(int[] nums, int i, int j, int min, int max)
        {
            if(max - min != j - i)
            {
                return false;
            }
            bool[] unique = new bool[j - i + 1];

            for(int k = i; k <= j; k++)
            {
                if (unique[nums[k] - min])
                {
                    return false;
                }
                else
                    unique[nums[k] - min] = true;
            }
            return true;
        }
    }
}
