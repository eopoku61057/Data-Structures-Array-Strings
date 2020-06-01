using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    {
        // Time complexity 0(n)
        // Space complexity 0(1)
        public Boolean validPalindrome(String s)
        {
            char[] cs = s.ToCharArray();
            int low = 0;
            int high = cs.Length - 1;

            while (low < high)
            {
                if (cs[low] != cs[high])
                {
                    return IsValidPalindrome(cs, low + 1, high) || IsValidPalindrome(cs, low, high - 1);
                }
                low++;
                high--;
            }

            return true;
        }

        private Boolean IsValidPalindrome(char[] cs, int start, int end)
        {
            while (start < end)
            {
                if (cs[start] != cs[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
