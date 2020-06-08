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
        /* Time complexity: \mathcal{O}(n\log{n} + m\log{m})O(nlogn+mlogm), 
        /*where nn and mm are the lengths of the arrays. We sort two arrays independently, and then do a linear scan.
         Space complexity: \mathcal{O}(1)O(1). We sort the arrays in-place. We ignore the space to store the output as it is not
         essential to the algorithm itself.
        */
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0, j = 0, k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    nums1[k++] = nums1[i++];
                    j++;
                }
            }
            
            int[] dd = new int[nums1.Length];
            Array.Copy(nums1, 0, dd, 0, k);
            return dd;
        }
    }
}
