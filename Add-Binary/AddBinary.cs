using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /*
            Time complexity: \mathcal{O}(\max(N, M))O(max(N,M)), where NN and MM are lengths of the input strings a and b.
            Space complexity: \mathcal{O}(\max(N, M))O(max(N,M)) to keep the answer.
         */
        public string AddBinary(string a, string b)
        {
            // Initialize result
            string result = "";
            int s = 0;

            // Traverse both strings starting from last characters
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {
                // computes sum of last digits and carry
                s += ((i >= 0) ? a[i] - '0' : 0);
                s += ((j >= 0) ? b[j] - '0' : 0);

                // if current digit sum is 1 or 3, add 1 to result
                result = (char)(s % 2 + '0') + result;

                // Compute carry
                s /= 2;

                // Move to next digits
                i--;
                j--;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string a = "1101", b = "100";
            var data = new SortedZeros();
            var d = data.AddBinary(a, b);
            Console.Write(d + " ");
        }
    }
}
