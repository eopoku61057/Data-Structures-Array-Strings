/*
Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

Note: The algorithm should run in linear time and in O(1) space.
*/

// Big O : 0(N)  and Space complexity 0(1)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algorithm
{
    class Solution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            int contA = 0;
            int contB = 0;
            int count1 = 0;
            int count2 = 0;

            foreach (var num in nums)
            {
                if(num == contA)
                {
                    count1++;
                }
                else if (num == contB)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    contA = num;
                    count1++;
                }
                else if (count2 == 0)
                {
                    contB = num;
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = 0;
            count2 = 0;
            foreach(var num in nums)
            {
                if (num == contA)
                {
                    count1++;
                }
                else if (num == contB)
                {
                    count2++;
                }
            }

            IList<int> data = new List<int>();
            if (count1 > nums.Length / 3)
            {
                data.Add(contA);
            }
            if(count2 > nums.Length / 3)
            {
                data.Add(contB);
            }
            return data;
        }
    }
}
