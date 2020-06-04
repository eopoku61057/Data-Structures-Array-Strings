/*
    Given a set of distinct integers, nums, return all possible subsets (the power set).
    Note: The solution set must not contain duplicate subsets.

 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            int n = nums.Length;

            for (int i = (int)Math.Pow(2, n); i < (int)Math.Pow(2, n + 1); i++)
            {
                // generate bitmask, from 0..0 to 1...11
                string bitmask = Convert.ToString(i).Substring(1);

                // append subset corresponding to that bitmask
                List<int> curr = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (bitmask[j] == '1') curr.Add(nums[j]);
                }
                output.Add(curr);
            }
            return output;
        }
    }

}
