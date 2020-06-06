/*
    Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
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
        // Time complexity: O(n^2)
        // Space complexity: 0(1)
        public String longestPalindrome(String s)
        {
            if (s == null || s.Length < 1)
            {
                return "";
            }
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundcenter(s, i, i);
                int len2 = ExpandAroundcenter(s, i, i + 1);
                int len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1);
        }

        private int ExpandAroundcenter(string s, int left, int right)
        {
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
