using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /*
         * Time complexity : {O}(n + m)
            Space complexity : O(m).
         */
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // make a copy of nums1
            int[] nums1_copy = new int[m];
            Array.Copy(nums1, 0, nums1_copy, 0, m);

            // two pointers for nums1_copy and nums2
            int p1 = 0;
            int p2 = 0;

            // Set pointer for nums1
            int p = 0;

            // compare elements from nums1_copy and nums2 and add the smalles one into num1
            while ((p1 < m) && (p2 < n))
            {
                nums1[p++] = (nums1_copy[p1] < nums2[p2]) ? nums1_copy[p1++] : nums2[p2++];
            }

            // if there are still elements to add
            if (p1 < m)
            {
                Array.Copy(nums1_copy, p1, nums1, p1 + p2, m + n - p1 - p2);
            }
            if (p2 < n)
            {
                Array.Copy(nums2, p2, nums1, p1 + p2, m + n - p1 - p2);
            }
        }

        static void Main(string[] args)
        {
            int[] str = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] str2 = new int[] { 2, 5, 4 };
            int n = 3;
            var data = new SortedZeros();
            data.Merge(str, m, str2, n);

            foreach (var d in str)
            {
                Console.Write(d + "");
            }
        }

    }
}
