using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            IList<string> x = FindStrobogrammatic(n);
            foreach( var r in x)
            {
                Console.WriteLine(r);
            }
            
        }
        public static IList<string> FindStrobogrammatic(int n)
        {
            return DFS(n, n);
        }

        private static IList<string> DFS(int m, int n)
        {
            IList<string> output = new List<string>();
            if (m == 0) return new List<string>() { "" };
            if (m == 1) return new List<string>() { "0", "1", "8" };
            if (m == 2) return new List<string>() { "11", "69", "88", "96"};

            IList<string> tmp = DFS(m - 2, n);
            foreach (var x in tmp)
            {
                if (m != n)
                {
                    output.Add("0" + x + "0");
                    return output;
                }
                output.Add("1" + x + "1");
                output.Add("8" + x + "8");
                output.Add("6" + x + "9");
                output.Add("9" + x + "6");
            }
            return output;
        }
    }
}
