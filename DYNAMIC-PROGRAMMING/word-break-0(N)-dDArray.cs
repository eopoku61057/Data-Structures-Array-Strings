using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    /*Solution uses 2D Array and dynamic programming by recursively calling the helper method and passing in
    for lo, i and i + 1, hi
    Time Complexity = 0(N)
    Space Complexity = 0(N)
     */
    public class NumMatrix
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int lo = 0, hi = s.Length - 1;
            bool?[,] dp = new bool?[s.Length, s.Length];
            return Helper(s, wordDict, lo, hi, dp) ?? default(bool);
        }

        private bool? Helper(string s, IList<string> wordDict, int lo, int hi, bool?[,] dp)
        {
            if(wordDict.Contains(s.Substring(lo, hi - lo + 1)))
            {
                dp[lo, hi] = true;
            }
            else if (dp[lo, hi] != null)
            {
                return dp[lo, hi];
            }
            else if (lo == hi)
            {
                dp[lo, hi] = false;
            }
            else
            {
                for (int i = lo; i <= hi; i++)
                {
                    dp[lo, hi] = (Helper(s, wordDict, lo, i, dp) ?? default(bool)) && (Helper(s, wordDict, i + 1, hi, dp) ?? default(bool)) ? true : false;

                    if (dp[lo, hi] ?? default(bool))
                        break;
                }
            }
            return dp[lo, hi];
        }
    }

    static void Main(string[] args)
        {
            NumMatrix sb = new NumMatrix();

            string s = "leetcode";
            var set = new List<string>();
            set.Add("leet");
            set.Add("code");
            bool dd = sb.WordBreak(s, set);
            Console.Write(dd);
        }
}


