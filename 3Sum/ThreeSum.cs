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
        public List<List<int>> ThreeSum(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            List<List<int>> data = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if ((nums[i] + nums[j] + nums[j + 1]) == 0)
                    {
                        List<int> retData = AddToList(nums[i], nums[j], nums[j + 1]);
                        data.Add(retData);
                    }
                }
            }

            return data;
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
