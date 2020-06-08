/*
    Given two arrays, write a function to compute their intersection.
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
        // Time Complexity: 0(n + m)
        // Space complexity: 0(n + m)
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            foreach(var n in nums1)
            {
                set1.Add(n);
            }

            HashSet<int> set2 = new HashSet<int>();
            foreach(var x in nums2)
            {
                set2.Add(x);
            }

            if(set1.Count() < set2.Count())
            {
                return set_intersection(set1, set2);
            }
            else
                return set_intersection(set2, set1);
        }

        private int[] set_intersection(HashSet<int> set1, HashSet<int> set2)
        {
            List<int> output = new List<int>();
            foreach( int s in set1)
            {
                if(set2.Contains(s))
                {
                    output.Add(s);
                }
            }
            return output.ToArray();
        }
    }
}
