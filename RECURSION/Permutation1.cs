/*
    Given a collection of distinct integers, return all possible permutations.
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /* Time complexity : \mathcal{O}(\sum_{k = 1}^{N}{P(N, k)})O(∑ 
        k=1N
​	
        P(N, k)) where P(N, k) = \frac{N!}{(N - k)!} = N(N - 1) ... (N - k + 1)P(N, k)= (N−k)!N!=N(N−1)...(N−k+1)
        
            Space Complexity: 0(N!) since one has to keep N! solutions
         */
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();

            // convert nums into list since the output is a list of lists
            List<int> nums_lst = new List<int>();
            foreach (var num in nums)
            {
                nums_lst.Add(num);
            }

            int n = nums.Length;
            BackTrack(n, nums_lst, output, 0, nums);
            return output;
        }

        private void BackTrack(int n, List<int> nums_lst, IList<IList<int>> output, int first, int[] nums)
        {
            // if all intergers are used up
            if (first == n)
            {
                output.Add(new List<int>(nums_lst));
            }

            for (int i = first; i < n; i++)
            {
                // place i-th integer first in the current permutation
                Swap(nums, first, i);

                //use next integers to complete the permutations
                BackTrack(n, nums_lst, output, first + i, nums);
                // backtrack
                Swap(nums, first, i);
            }
        }

        private void Swap(int[] nums, int first, int i)
        {
            int tmp = nums[first];
            nums[first] = nums[i];
            nums[i] = tmp;
        }
    }
}
