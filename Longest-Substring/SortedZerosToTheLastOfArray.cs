using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 0, 1, 0, 3, 12, 99, 100, 28, 19, 0 };
            SortedZeros(nums);

            foreach(var x in nums)
            {
                Console.WriteLine(x);
            }
        }

        private static void SortedZeros(int[] nums)
        {
            int len = nums.Length;
            int nextValue = 0;

            for (int i = 0; i < len; i++)
            {
                while(nums[i] != 0)
                {
                    if (i != nextValue)
                    {
                        nums[nextValue] = nums[i];
                        nums[i] = 0;
                    }
                    nextValue++;
                }
            }

        }
    }
}
