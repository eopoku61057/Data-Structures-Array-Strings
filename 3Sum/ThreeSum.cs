// Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? 
// Find all unique triplets in the array which gives the sum of zero.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> data = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    twoSum(nums, i, data);
                }
            }

            return data;
        }

        private void twoSum(int[] nums, int i, IList<IList<int>> data)
        {
            int low = i + 1, high = nums.Length - 1;
            while (low < high)
            {
                int sum = nums[i] + nums[low] + nums[high];
                if (sum < 0 || (low > i + 1 && nums[low] == nums[low - 1]))
                {
                    ++low;
                }
                else if (sum > 0 || (high < nums.Length - 1 && nums[high] == nums[high + 1]))
                {
                    --high;
                }
                else
                {
                    List<int> retData = AddToList(nums[i], nums[low++], nums[high--]);
                    data.Add(retData);
                }


            }
        }

        private List<int> AddToList(int v1, int v2, int v3)
        {

            List<int> listSet = new List<int>();
            listSet.Add(v1);
            listSet.Add(v2);
            listSet.Add(v3);

            return listSet;
        }
    }
}

