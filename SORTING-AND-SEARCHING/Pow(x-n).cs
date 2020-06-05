/*
Implement pow(x, n), which calculates x raised to the power n (xn).
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
        // Time Complexity: 0(logn)
        // Space Complexity: 0(1)
        public double MyPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            double current_product = x;

            for (long i = N; i > 0; i /= 2)
            {
                if((i % 2) == 1)
                {
                    ans = ans * current_product;
                }
                current_product = current_product * current_product;
            }
            return ans;
        }

        // alternative solution with Time complexity: 0(N) and space complexity:0(1)
        public double myPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            for (long i = 0; i < N; i++)
                ans = ans * x;
            return ans;
        }
    }
}
