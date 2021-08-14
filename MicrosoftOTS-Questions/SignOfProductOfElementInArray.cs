//Question 2 - Coding(Find Sign of product of all element in an array multiplied Together.E.g:
//given an array like[-2, 3, 5, -9], return 1,0 or - 1 if the product of all elements in the array is positive,
//0 or negative respectively).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2 };
            int ret = FingSignOfProduct(nums);
            Console.WriteLine(ret);
        }

        private static int FingSignOfProduct(int[] nums)
        {
            int sign = -1, product = 1;
            if (nums.Length == 0)
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
            }

            if (product > 0)
            {
                sign = 1;
                return sign;
            }

            return sign;
        }
    }
}


