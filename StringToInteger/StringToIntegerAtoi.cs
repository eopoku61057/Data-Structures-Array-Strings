using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class StringToInteger
    {
        public int StringToInteger(string s)
        {
            int i = 1, j = 0, k = 0;
            // validate to make sure string is not empty or null
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            // handle all leading spaces
            while(s[k] == ' ')
            {
                k++;
                if (k >= s.Length)
                {
                    return 0;
                }
            }

            // handle the sign of the number
            if (s[k] == '-')
            {
                i = -1;
                k++;
            }
            else if (s[k] == '+')
            {
                k++;
            }

            // handle the overflow and invalid input
            while (k < s.Length && s[k] >= '0' && s[k] <= '9')
            {
                if(j > int.MaxValue / 10 || (j == int.MaxValue / 10 && s[k] - '0' > 7))
                {
                    if (i == 1)
                    {
                        return int.MaxValue;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }
                j = j * 10 + (s[k] - '0');
                k++;
            }
            
            return j * i;
        } 

    }
}
