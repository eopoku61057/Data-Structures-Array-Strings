using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public string minRemove(string s)
        {
            StringBuilder sb = new StringBuilder();
            int open = 0;

            foreach (char c in s.ToCharArray())
            {
                if(c =='(')
                {
                    open++;
                }
                else if (c == ')')
                {
                    if (open == 0) continue;
                    open--;
                }
                sb.Append(c);
            }

            StringBuilder result = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                if(sb[i] == '(' && open-- > 0) continue;
                result.Append(sb[i]);
            }
            IEnumerable<char> x = result.ToString().Reverse();
            return x.ToString();
        }
    }
}
