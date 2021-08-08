/*
    Given a collection of numbers that might contain duplicates, return all possible unique permutations.
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public static IList<IList<int>> output = new List<IList<int>>();
        public static List<int> set = new List<int>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            if (nums.Length == 0) return output;

            bool[] used = new bool[nums.Length];
            BackTrack(nums, used);
            return output;
        }
        private static void BackTrack(int[] nums, bool[] used)
        {
            if(set.Count == nums.Length)
            {
                output.Add(new List<int>(set));
                return;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;

                // if we've not use index and index greater than zero and previous index is not equal to 
                // index and previous index was used
                if((!used[i]) && !(i > 0 && nums[i] == nums[i - 1] && !used[i - 1]))
                {
                    set.Add(nums[i]);
                    used[i] = true;
                    BackTrack(nums, used);
                    set.Remove(nums[i]);
                    used[i] = false;
                }
            }
        }
    }
}
