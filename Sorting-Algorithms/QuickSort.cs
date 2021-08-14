using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortingAlgorithm
    {   // Time taken by Quick sort depends upon the input array and partition strategy
        // Time complexity is = bg 0(nlogn)
        // Worst Case time complexity is 0(n^2) it's quicker in practice than Merge sort despite the worst case
        /* The main function that implements QuickSort() 
            arr[] --> Array to be sorted, 
            low --> Starting index, 
        high --> Ending index */
        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi i partitioning index, arr[pi] is now at right place */
                int pi = Partition(arr, low, high);

                // Recursively sort elements before Partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            /* This function takes last element as pivot, 
                places the pivot element at its correct 
                position in sorted array, and places all 
                smaller (smaller than pivot) to left of 
                pivot and all greater elements to right 
            of pivot */

            int pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // if current element is smaller than pivot
                if (arr[j] < pivot)
                {
                    i++;
                    // perform swap operation
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;

        }

        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> list = new List<int>();

            int r1 = 0, r2 = matrix.Length - 1;
            int c1 = 0, c2 = matrix[0].Length - 1;
            while(r1 <= r2 && c1 <= c2)
            {
                for (int i = c1; i <= c2; i++) list.Add(matrix[r1][i]);
                for (int i = r1 + 1; i <= r2; i++) list.Add(matrix[i][c2]);
                if(r1 < r2 && c1 < c2)
                {
                    for (int i = c2 - 1; i > c1; i--) list.Add(matrix[r2][i]);
                    for (int i = r2; i > r1; r1--) list.Add(matrix[i][c1]);
                }
            }
        }
    }
}
