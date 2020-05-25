using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortingAlgorithms
    {
       public void SelectionSort(int[] arr)
        {
            // Time Complexity: O(n^2) as there are two nested loops.
            // Auxilliary Space: O(1) it never makes more than O(n) swaps and can useful when memory write is a costly operation
            int minIndex = 0;
            int temp = 0;
            int len = arr.Length;

            // Loop through unsorted array
            for (int i = 0; i < len - 1; i++)
            {
                // finding the minimum index in unsorted array
                minIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // swap the found minimum element withthe first element
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
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
