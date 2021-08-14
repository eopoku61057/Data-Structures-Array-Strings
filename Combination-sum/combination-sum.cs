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
            int[] nums = { 2, 3, 6, 7 };
            IList<IList<int>> ret = CombinationSum(nums, 7);
            var dd = ret;
        }

        private static IList<IList<int>> CombinationSum(int[] nums, int target)
        {
            BackTrack(target, nums, 0);
            return output;
        }

        private static void BackTrack(int target, int[] nums, int start)
        {
            if (target == 0)
            {
                output.Add(new List<int>(set));
                return;
            }
            else if (target < 0)
            {
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                set.Add(nums[i]);
                BackTrack(target - nums[i], nums, i);
                set.RemoveAt(set.Count - 1);
            }
        }
    }
}


