using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class FirstNonRepeatingCahracter
    {
        // it will loop through the string and get the first non-repeated string
        // suppose the string is dotNetPearl it will return d
        // this solution uses big o(n^2) so it is going to take more time as the input n increases
        // we need to find a better solution to this
        public char FirstNonRepeatingCahracter(string s)
        {
            // DotNetPearls
            for (int i = 0; i < s.Length; i++)
            {
                Boolean seenDuplicate = false;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        seenDuplicate = true;
                        break;
                    }
                }
                if(!seenDuplicate)
                {
                    return s[i];
                }
            }
            return '_';
        }
    }
}
