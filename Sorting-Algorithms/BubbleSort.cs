using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortingAlgorithm
    {
        // Worst and Average case Time Complexity = Big O(n^2), worst case occurs when array is reverse sorted
        // Best Case O(n) linear it occurs when array is already sorted
        // Auxilliary space = O(1)
       public void BubbleSort(int[] arr)
        {
            int len = arr.Length, temp = 0;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // perform our swap
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
