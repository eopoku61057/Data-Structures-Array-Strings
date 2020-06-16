using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class LongestSubstring
    {
        /*
            Time complexity : O(2n) = O(n)O(2n)=O(n). In the worst case each character will be visited twice by ii and jj.

            Space complexity : O(min(m, n))O(min(m,n)). Same as the previous approach. We need O(k)O(k) space for the sliding window, 
            where kk is the size of the Set. The size of the Set is upper bounded by the size of the string nn and the size of the charset/alphabet mm.
         */
        // this solution has a bug, it returns the sub sequence instead of the sustring
       public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int i = 0, j = 0, ans = 0;
            while(i < s.Length && j < s.Length)
            {
                if(!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }
            }
            return ans;
        }
    }
}


