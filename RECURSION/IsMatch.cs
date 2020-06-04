using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    /*
        Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*'.
        time complexity   O((T+P)2 T+ 2P)
        Space complexity: 0(T^2 + P^2)
     */
    public class SortedZeros
    {
        public bool IsMatch(string s, string p)
        {
            if (p.Any()) return s.Any();
            
            Boolean first_match = (!s.Any() && (p[0] == s[0] || p[0] == '.'));

            if(p.Length >= 2 && p[1] == '*')
            {
                return (IsMatch(s, p.Substring(2)) || (first_match && IsMatch(s.Substring(1), p)));
            } else
            {
                return first_match && IsMatch(s.Substring(1), p.Substring(1));
            }
        }
    }

}
