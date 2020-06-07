/*
    Given a collection of intervals, merge all overlapping intervals.
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
        public int[][] merge(int[][] intervals)
        {
            Comp data = new Comp();
            Array.Sort(intervals, data);

            LinkedList<int[]> merged = new LinkedList<int[]>();

            foreach (int[] interval in intervals)
            {
                if (merged.Count() == 0 || merged.Last()[1] < interval[0])
                {
                    merged.AddLast(interval);
                }
                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }


            return merged.ToArray();
        }

    }

    public class Comp : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return a[0] < b[0] ? -1 : a[0] == b[0] ? 0 : 1;
        }
    }

        static void Main(string[] args)
        {
            SortedZeros sb = new SortedZeros();
            int[] str = new int[] { 23, 2, 4, 6, 7 };
            string[] stri = new string[] { "leet", "code"};

            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 3 };
            jaggedArray[1] = new int[] { 2, 6 };
            jaggedArray[2] = new int[] { 8, 10 };
            jaggedArray[3] = new int[] { 15, 18 };

            int[][] data = sb.merge(jaggedArray);
            foreach(var dd in data)
            {
                foreach (var x in dd)
                {
                    Console.WriteLine(x + " ");
                }
            }
            
           
        }
}
