using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new[] { "paper", "true", "soap", "floppy", "flower", "Emmanuel" };
            var obj = new SortedZeros();
            obj.SelectionSort(str, str.Length);
            obj.PrintArray(str);

            int[] arrayObj = new[] { 2, 5, 8, 9, 1, 0, 2 };
            
        }

    

    public void SelectionSort(string[] arr, int n)
        {
            int len = arr.Length;

            // Loop through unsorted array
            for (int i = 0; i < len - 1; i++)
            {
                // finding the minimum index in unsorted array
                minIndex = i;
                string minStr = arr[i];
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j].CompareTo(minStr) < 0)
                    {
                        minStr = arr[j];
                        minIndex = j;
                    }
                }
                // swap the found minimum element withthe first element
                if(minIndex != i)
                {
                    string tempStr = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = tempStr;
                }
            }
        }

        public void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

    }
}

