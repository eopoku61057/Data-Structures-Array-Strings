using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public static int RomanToInt(string s)
    {
             int ans = 0, value1 = 0, value2 = 0;
            for (int i = 0; i <= s.Length - 1;)
            {
                value1 = FindNumber(s[i]);
                if(i + 1 <= s.Length - 1)
                {
                    value2 = FindNumber(s[i + 1]);
                }
                if(value1 < value2)
                {
                    ans += (value2 - value1);
                    i += 2;
                }
                else
                {
                    ans += value1;
                    i++;
                }
            }
            return ans;
            
    }

    private static int FindNumber(char c)
     {
            int ret = -1;
            switch(c)
            {
                case 'I':
                    ret = 1;
                    break;
                case 'V':
                    ret = 5;
                    break;
                case 'X':
                    ret = 10;
                    break;
                case 'L':
                    ret = 50;
                    break;
                case 'C':
                    ret = 100;
                    break;
                case 'D':
                    ret = 500;
                    break;
                case 'M':
                    ret = 1000;
                    break;
                default:
                    ret = -1;
                    break;
            }
            return ret;
    }
}
