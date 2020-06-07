using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    { // Continuous subarrays whose sum equals to k
        public int SubArraySumEqualsK(int[] nums, int k)
        {
            if (nums.Length == null) return -1;
            Dictionary<int, int> counts = new Dictionary<int, int>();
            counts.Add(0, 1);

            int sum = 0, count = 0;
             
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (counts.ContainsKey(sum - k))
                {
                    count = count + counts.GetValueOrDefault(sum - k);
                }
                else counts.Add(sum, counts.GetValueOrDefault(sum, 0) + 1);
            }
            return count;
            
        }

        static void Main(string[] args)
        {
            SortedZeros sb = new SortedZeros();
            int[] str = new int[] { 1, 2, 3, 3 };
            int n = str.Length;

            int data = sb.SubArraySumEqualsK(str, 6);
            Console.WriteLine(data + " ");

        }
    }
}
