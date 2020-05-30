using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public int lengthOfLongestSubstringKDistinct(string s, int k)
        {
            // time complexity: 0(N)
            // Space complexity 0(k)
            if(k == 0)
            {
                return 0;
            }

            var chardict = new Dictionary<char, int>();

            int maxlen = 0;
            int left = 0;
            int right = 0;
            int n = s.Length;

            while (right < n && left <= right)
            {
                if (!chardict.ContainsKey(s[right]))
                {
                    chardict.Add(s[right], 1);
                }
                else
                {
                    chardict[s[right]]++;
                }

                if (chardict.Count <= k)
                {
                    maxlen = Math.Max(maxlen, right - left + 1);
                    right++;
                }
                else
                {
                    chardict[s[left]]--;
                    if(chardict[s[left]] == 0)
                    {
                        chardict.Remove(s[left]);
                    }
                    left++;
                    right++;
                }
            }
            return maxlen;
        }
    }
}
