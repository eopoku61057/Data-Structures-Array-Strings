/*
Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or 
more dictionary words Note:
The same word in the dictionary may be reused multiple times in the segmentation.
You may assume the dictionary does not contain duplicate words.
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
        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> set = new HashSet<string>();
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(dp[j] && set.Contains(s.Substring(j, i)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
