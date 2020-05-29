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
        public int LongestSubstring(string s)
        {
            HashSet<Char> set = new HashSet<char>();
            int t = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!set.Contains(c))
                {
                    set.Add(s[i]);
                    t = Math.Max(t, i);
                }
            }
            
            return t;
        }
    }
}


