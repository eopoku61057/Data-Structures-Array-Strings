using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program : SortedZeros
    {
        static void Main(string[] args)
        {
            // Two-Dimensional Array
            int[,] numbers2D = new int[3, 2] 
            { 
                { 9, 99 }, 
                { 3, 33 }, 
                { 5, 55 }
            };

            // 3 * 3
            int[,] dataTest2D = new int[3, 3] 
            { 
                {3, 5, 7}, 
                {4, 3, 8},
                {9, 6, 9},
            };

            // A similar array with string elements.
            int[,] matrix = new int[4, 4]
            {
                 {1, 2, 3, 6},
                 {4, 5, 6, 4},
                 {7, 8, 9, 6},
                 {7, 8, 9, 2},
            };

            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(0);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            // using foreach to print out the 2 * 2 in one straightline
            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine();
            for (int i = 0; i < dataTest2D.GetLength(0); i++)
            {
                for (int j = 0; j < dataTest2D.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", dataTest2D[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

    }
}
