using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        private static IList<IList<int>> output = new List<IList<int>>();
        private static List<int> set = new List<int>();
        static void Main(string[] args)
        {
            int[] nums = { -7, -6, 0, 2, 3, 6, 7 };
            int[] ret = SortedSqaureArray(nums);
            var dd = ret;
        }

        private static int[] SortedSqaureArray(int[] nums)
        {
            if (nums.Length == 0)
                return new int[nums.Length];

            int[] arr = new int[nums.Length];
            //int j = arr.Length - 1;
            int start = 0, end = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[start]) > nums[end])
                {
                    arr[i] = nums[start] * nums[start];
                    start++;
                }
                else
                {
                    arr[i] = nums[end] * nums[end];
                    end--;
                }
            }

            return arr;
        }
    }
}


