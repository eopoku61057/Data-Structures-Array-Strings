using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class LongestSubstring
    {
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


