using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /*
         * Time complexity : O(N) where NN represents the number of elements in the input array. We use one iteration to construct the array LL, 
         * one to construct the array RR and one last to construct the answeranswer array using LL and RR.
            Space complexity : O(N) used up by the two intermediate arrays that we constructed to keep track of product of elements to the left and right.
         * */
        public int[] ProductExceptSelf(int[] nums) //{ 1, 3, 4 }
        {
            // the length of the input array
            int length = nums.Length;

            // left and right arraus
            int[] L = new int[length];
            int[] R = new int[length];

            // final answer array to be returned
            int[] answer = new int[length];

            // L[i] contains the product of all the elements to the left: Note for the elements at index"0", 
            // there are no elements to the left, so L[0] would be 1
            L[0] = 1;
            for (int i = 1; i < length; i++)
            {
                // L[i - 1] already contains the product of elements to the left of 'i -1' Simply multiplying it with nums[i - 1] 
                // would give the product of all elements to the left of index 'i'
                L[i] = nums[i - 1] * L[i - 1];
                //      {0, 4, 9}
            }

            //R[i] contains the product of all the elements to the right Note: for the element at index 'length - 1'
            // There are no elements to the right so the R[length - 1] would be 1
            R[length - 1] = 1;
            for (int i = length - 2; i >= 0; i--)
            {
                // R[i + 1] already contains the product of elements to the right of 'i + 1'
                // Simply multiplying it with nums[i + 1] would give the product of all elements to the right of index 'i'
                R[i] = nums[i + 1] * R[i + 1]; // 3 - 2 = 1
                // { 4, 0, }
            }

            // Constructing the answer array
            for (int i = 0; i < length; i++)
            {
                // For the first element, R[i] would be product except self
                // For the last element of the array, product except self would be L[i]
                // Else, multiple product of all elements to the left and to the right
                answer[i] = L[i] * R[i]; //{ 0, 0, }
                // { 0, 4, 9}
                 //  { 4, 0 }
            }

            return answer;
        }
    }
}
