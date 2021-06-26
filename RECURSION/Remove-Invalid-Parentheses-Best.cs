using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "()())()";
            List<string> ret = RemovedInvalidParentheses(s);
        }

        private static List<string> RemovedInvalidParentheses(string s)
        {
            List<string> ans = new List<string>();
            int l = 0, r = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    l++;
                }
                else if (c == ')')
                {
                    if (l == 0)
                    {
                        r++;
                    }
                    else if (l > 0)
                    {
                        l--;
                    }
                }
            }
            DFS(s, 0, l, r, ans);
            return ans;
        }

        private static void DFS(string s, int start, int l, int r, List<string> ans)
        {
            //base case
            if (l == r)
            {
                if (IsValid(s))
                {
                    ans.Add(s);
                }
            }

            for (int i = start; i <= s.Length - 1; i++)
            {
                if (i != start && s[i] == s[i + 1])
                    continue;
                if (s[i] == '(' || s[i] == ')')
                {
                    StringBuilder cur = new StringBuilder(s);
                    cur.Replace(s[i], s[i + 1]);
                    if (r > 0 && s[i] == ')')
                    {
                        DFS(cur.ToString(), i, l, r - 1, ans);
                    }
                    else if (l > 0 && s[i] == '(')
                    {
                        DFS(cur.ToString(), i, l - 1, r, ans);
                    }
                }
            }
        }

        private static bool IsValid(string s)
        {
            int count = 0;
            var data = s.ToCharArray();
            foreach (var x in data)
            {
                if (x == '(') count++;
                if (x == ')') count--;
                if (count < 0) return false;
            }
            return count == 0;
        }
    }
}


