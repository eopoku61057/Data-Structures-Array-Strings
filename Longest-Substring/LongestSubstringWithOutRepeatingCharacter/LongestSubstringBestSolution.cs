using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    // time complexity of this is Big O(n) which is linear, space complexity is the size of the charset
    // this method is efficient and works for all test cases
    public class SortedZeros
    {
        public int LongestSubstring(string s)
        {
            int ans = 0;

            int[] index = new int[128]; // set of ASCII characters int[26] is for letters 'a' to 'z' or 'A' to 'Z'

            for (int i = 0, j = 0;  i < s.Length; i++)
            {
                char c = s[i];
                j = Math.Max(index[c], j);
                ans = Math.Max(ans, i - j + 1);
                index[c] = i + 1;
            }
            
            return ans;
        }
    }
}
