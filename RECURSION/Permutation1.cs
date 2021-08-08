using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        /* Time complexity : o(n!)
        
            Space Complexity: 0(N!) since one has to keep N! solutions
         */
        public static IList<IList<int>> output = new List<IList<int>>();
        public static List<int> set = new List<int>();
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> data = Permutate(nums);

        }

        private static IList<IList<int>> Permutate(int[] nums)
        {
            if (nums.Length == 0) return output;
            bool[] used = new bool[nums.Length];
            BackTrack(nums, used);
            return output;
        }

        private static void BackTrack(int[] nums, bool[] used)
        {
            if (set.Count == nums.Length)
            {
                output.Add(new List<int>(set));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i])
                    continue;

                set.Add(nums[i]);
                used[i] = true;
                BackTrack(nums, used);
                set.Remove(nums[i]);
                used[i] = false;
            }
        }
    }
}


