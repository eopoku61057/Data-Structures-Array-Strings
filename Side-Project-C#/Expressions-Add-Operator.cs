/*
Given a string that contains only digits 0-9 and a target value, return all possibilities to add binary operators (not unary) +, -, or * between 
the digits so they evaluate to the target value.

Example 1:

Input: num = "123", target = 6
Output: ["1+2+3", "1*2*3"] 
 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Solution
    {
        static int T;
        static string N;
        static IList<string> res;
        static char[] Ops = new char[] { '+', '-', '*' };

        public IList<string> AddOperators(string num, int target)
        {
            if (num.Length == 0) return new List<string>();
            T = target;
            N = num;
            res = new List<string>();
            BT(0, 0, string.Empty, null);
            return res;
        }

        public void BT(int idx, long sumSofar, string subres, long? prev)
        {
            if (idx == N.Length)
            {
                if(sumSofar == T)
                {
                    res.Add(subres);
                }
                return;
            }

            for (int en = idx; en < N.Length; en++)
            {
                string curStr = N.Substring(idx, en + 1 - idx);
                long cur = long.Parse(curStr);

                if(en != idx && N[idx] == '0')
                {
                    break;
                }

                if(idx == 0)
                {
                    BT(en + 1, sumSofar + cur, curStr, null);
                }
                else
                {
                    if (prev != null)
                    {
                        BT(en + 1, (sumSofar - prev.Value) + (cur * prev.Value), subres + "*" + curStr, (cur * prev.Value));
                    }
                    else
                    {
                        BT(en + 1, (sumSofar * cur), subres + "*" + curStr, (sumSofar * cur));
                    }

                    BT(en + 1, sumSofar + cur, subres + "+" + curStr, cur);
                    BT(en + 1, sumSofar - cur, subres + "-" + curStr, -cur);
                }
            }
        }
    }
}
