using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /*
            Time complexity : \mathcal{O}(N)O(N) in the worst case when string lengths are close enough abs(ns - nt) <= 1, where N is a number of characters in the longest string. 
            \mathcal{O}(1)O(1) in the best case when abs(ns - nt) > 1.
            Space complexity : \mathcal{O}(N)O(N) because strings are immutable in Python and Java and to create substring costs \mathcal{O}(N)O(N) space.
        
         */
        public Boolean isOneEditDistance(string s, string t)
        {
            int ns = s.Length;
            int nt = s.Length;

            // Ensure that s is shorter than t
            if (ns > nt)
            {
                return isOneEditDistance(t, s);
            }

            // The strings are not one edit away distance if the length diff is more than 1
            if (nt - ns > 1)
            {
                return false;
            }

            for (int i = 0; i < ns; i++)
            {
                if (s[i] != t[i])
                {
                    // if string have same length
                    if (ns == nt)
                    {
                        return s.Substring(i + 1).Equals(t.Substring(i + 1));
                    }
                    else // if string have different lengths
                    {
                        return s.Substring(i).Equals(t.Substring(i + 1));
                    }
                }
            }

            //if there is no difs on ns distance, the strings are one edit away only
            // if t has one more character
            return (ns + 1 == nt);
        }
    }
}
