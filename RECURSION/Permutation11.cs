/*
    Given a collection of numbers that might contain duplicates, return all possible unique permutations.
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public IList<IList<int>> output = new List<IList<int>>();
        public IList<IList<int>> findPermutations(int[] str, int index, int n)
        {
            if (index >= n)
            {
                List<int> ins = new List<int>();
                foreach (var i in str)
                {
                    ins.Add(i);
                    Console.Write(i + " ||  ");
                }
                output.Add(ins);
                return output;
            }

            for (int i = index; i < n; i++)
            {
                // Proceed further for str[i} only if it doesn't match with any of the characters after str[index]
                bool check = ShouldSawp(str, index, i);
                if (check)
                {
                    Swap(str, index, i);
                    IList<IList<int>> data = findPermutations(str, index + 1, n);
                    Swap(str, index, i);
                }
            }

            return output;
        }

        private void Swap(int[] str, int index, int i)
        {
            int c = str[index];
            str[index] = str[i];
            str[i] = c;
        }

        // Returns true if str[curr] does not matches with any of the characters after str[index]
        private bool ShouldSawp(int[] str, int index, int current)
        {
            for (int i = index; i < current; i++ )
            {
                if(str[i] == str[current])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
