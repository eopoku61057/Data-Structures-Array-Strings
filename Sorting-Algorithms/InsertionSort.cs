using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortingAlgorithm
    {
        // time complexity is O(n^2), Auxilliary Space is O(1)
        // Boundary cases: Insertion sort takes maximum time to sort if elements are sorted in reverse order. And it takes time (order of n)
        // when elements are already sorted.
       public void InsertionSort(int[] arr)
        {
            int len = arr.Length;

            for (int i = 1; i < len; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
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
