/*
Alice and Bob have candy bars of different sizes: A[i] is the size of the i-th bar of candy that Alice has, and B[j] is 
the size of the j-th bar of candy that Bob has.

Since they are friends, they would like to exchange one candy bar each so that after the exchange, they both have 
the same total amount of candy.  (The total amount of candy a person has is the sum of the sizes of candy bars they have.)

Return an integer array ans where ans[0] is the size of the candy bar that Alice must exchange, and ans[1] is the size of 
the candy bar that Bob must exchange.

If there are multiple answers, you may return any one of them.  It is guaranteed an answer exists.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algorithm
{
    class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int sumA = 0, sumB = 0;
            foreach(var x in A)
            {
                sumA += x;
            }
            foreach(var y in B)
            {
                sumB += y;
            }

            int d = (sumB - sumA) / 2;
            HashSet<int> set = new HashSet<int>();
            foreach(var x in B)
            {
                set.Add(x);
            }
            foreach(var y in A)
            {
                if (set.Contains(y + d))
                {
                    return new int[] { y, y + d };
                }
            }
            return new int[sumA];
        }

    }
}
