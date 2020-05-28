using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /* 
         * Complexity Analysis
            Time complexity : O(n). In worst case, only two scans of the whole array are needed.
            Space complexity : O(1). No extra space is used. In place replacements are done.
         */
        public void nextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while(i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                // perform swap
                Swap(nums, i, j);
            }
            // reverse
            Reverse(nums, i + 1);
        }

        private void Reverse(int[] nums, int start)
        {
            int i = start;
            int j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] i = new[] { 1, 2, 3 };
            var Test = new SortedZeros();
            Test.nextPermutation(i);

            foreach (var r in i)
            {
                Console.Write(r + " ");
            }
        }
    }
}
