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
        public Boolean validPalindrome(String s)
        {
            if (IsValidPalindrome(s))
            {
                return true;
            }

            int diffChars = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                char left = s[i];
                char right = s[s.Length - 1 - i];
                if(left == right)
                {
                    // chars do not match no point in removing them
                    continue;
                }

                //Start from outer chars and work your way in
                string modified = s.Remove(i, 1);
                if (IsValidPalindrome(modified))
                {
                    return true;
                }

                int endchar = s.Length - 1 - i;
                modified = s.Remove(endchar, 1);
                if (IsValidPalindrome(modified))
                {
                    return true;
                }

                // If we get here, removing the above pair of chars did not yield a good palindrome
                if (diffChars > 0)
                {
                    //If we have previously encountered different chars, 
                    //there is no point in trying the inner pairs
                    return false;
                }
                else
                {
                    //Make a note for next time around
                    diffChars++;
                }
            }
            return false;
        }

        private Boolean IsValidPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                char left = s[i];
                char right = s[s.Length - 1 - i];

                if( left != right)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
