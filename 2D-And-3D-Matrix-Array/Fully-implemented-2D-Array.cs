using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class _3DArray
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n / 2); j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - 1 - j];
                    matrix[i][n - 1 - j] = temp;
                }
            }
        }

        public static void Main(string[] args)
        {
            _3DArray sb = new _3DArray();

            int[][] mm = new int[3][];

            for (int i = 0; i < mm.Length; i++)
            {
                mm[i] = new int[3];
                for (int j = 0; j < mm[i].Length; j++)
                {
                    mm[i][j] = i * 3 + j + 1;
                }
            }

            for (int i = 0; i < mm.Length; i++)
            {
                for (int j = 0; j < mm.Length; j++)
                {
                    Console.Write(string.Format("{0} ", mm[i][j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            sb.Rotate(mm);
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < mm.Length; i++)
            {
                for (int j = 0; j < mm.Length; j++)
                {
                    Console.Write(string.Format("{0} ", mm[i][j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
