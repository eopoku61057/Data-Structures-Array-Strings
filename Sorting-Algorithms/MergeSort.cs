using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortingAlgorithm
    {
       public void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // find the middle point
                int m = (l + r) / 2;

                // sort first and second halves
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                // finallu, merge the sorted halves
                MergeSort(arr, l, m, r);
            }
        }

        private void MergeSort(int[] arr, int l, int m, int r)
        {
            // find sizes of two subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create Temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];

            /* Copy data into temp Arrays */
            for (int x = 0; x < n1; x++)
            {
                L[x] = arr[l + x];
            }

            for (int y = 0; y < n2; y++)
            {
                R[y] = arr[m + 1 + y];
            }

            /* merge the temp arrays */

            //Initialize indexes of first and second array
            int i = 0, j = 0;

            // Initialize index of merged subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
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
