/*
A message containing letters from A-Z is being encoded to numbers using the following mapping:

'A' -> 1
'B' -> 2
...
'Z' -> 26
Given a non-empty string containing only digits, determine the total number of ways to decode it.
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
        // time Complexity: 0(N)
        // space complexity: 0(N) the length of dp array
        public int NumDecodings(string s)
        {
            if(s == null || s.Length == 0)
            {
                return 0;
            }

            // Dp array to store the subproblem results
            int[] dp = new int[s.Length + 1];
            dp[0] = 1;
            // ways to decode a string of size 1 is 1. Unless the string is '0'
            // '0' doesn't have a single digit decode
            dp[1] = s[0] == '0' ? 0 : 1;

            for (int i = 2; i < dp.Length; i += 1)
            {
                //check if successful single decode is possible
                if (s[i - 1] != '0')
                {
                    dp[i] += dp[i - 1];
                }

                // check if successful two digit decode is possible
                int twoDigit = int.Parse(s.Substring(i - 2, i));
                if (twoDigit >= 10 && twoDigit < 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
            return dp[s.Length];
        }
    }
}
