using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    /*
       Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
       Time Complexity 0(n^2)
       Space 0(n);
     */
    public class SortedZeros
    {
        public string StringMultiply(string num1, string num2)
        {
            char[] chs1 = num1.ToArray();
            char[] chs2 = num2.ToArray();

            int n1 = chs1.Length;
            int n2 = chs2.Length;

            char[] result = new char[n1 + n2];
            Array.Fill(result, '0');

            for (int j = n2 - 1; j >= 0; j--)
            {
                for (int i = n1 -1; i >= 0; i--)
                {
                    int product = (chs1[i] - '0') * (chs2[j] - '0');
                    int tmp = result[i + j + 1] - '0' + product;

                    result[i + j + 1] = (char)(tmp % 10 + '0');
                    result[i + j] = (char)((result[i + j] - '0' + tmp / 10) + '0');
                }
            }

            StringBuilder sb = new StringBuilder();
            Boolean seen = false;
            foreach ( char c in result)
            {
                if (c == '0' && !seen)
                {
                    continue;
                }
                sb.Append(c);
                seen = true;
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }

        static void Main(string[] args)
        {
            string num1 = "123";
            string num2 = "456";
            var obj = new SortedZeros();
            string i = obj.StringMultiply(num1, num2);

            Console.Write(i + " ");
        }


    }
}
