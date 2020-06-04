/*
    A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).
    Find all strobogrammatic numbers that are of length = n.
    Input:  n = 2
    Output: ["11","69","88","96"]
 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        private char[,] mapping = new char[,]
        {
            {'0', '0' },
            {'1', '1' },
            {'6', '9' },
            {'8', '8' },
            {'9', '6' }
        };
        public IList<string> FindStrobogrammatic(int n)
        {
            List<string> res = new List<string>();
            if (n < 1) return res;
            char[] chs = new char[n];
            Helper(chs, 0, n - 1, res);
            return res;
        }

        private void Helper(char[] chs, int lo, int hi, List<string> res)
        {
            if (lo > hi)
            {
                if(chs.Length == 1 || chs[0] != '0')
                {
                    res.Add(chs.ToString());
                }

                return;
            }

            foreach (char map in mapping)
            {
                if (lo == hi && map != map) continue;
                chs[lo] = map;
                chs[hi] = map;
                Helper(chs, lo + 1, hi - 1, res);
            }
        }
    }

}
