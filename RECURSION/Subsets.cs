using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 1, 2, 3};
            IList<IList<int>> x = Subsets(n);
            foreach( var r in x)
            {
                foreach (var xx in r)
                {
                    Console.WriteLine(xx);
                }
            }
            
        }
        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            int n = nums.Length;

            for (int i = 0; i < n + 1; i++)
            {
                BackTracking(nums, output, new List<int>(), 0, i);
            }
            
            return output;
        }

        private static void BackTracking(int[] nums, IList<IList<int>> output, List<int> list, int lo, int hi)
        {
            if (list.Count == hi)
            {
                output.Add(new List<int>(list));
                return;
            }

            for(int i = lo; i < nums.Length; i++)
            {
                list.Add(nums[i]);
                BackTracking(nums, output, list, i + 1, hi);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
