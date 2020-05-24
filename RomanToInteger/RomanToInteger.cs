using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class RomanToIntegerClass
    {
        public int RomanToInteger(string s)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            values.Add("M", 1000);
            values.Add("D", 500);
            values.Add("C", 100);
            values.Add("L", 50);
            values.Add("X", 1);
            values.Add("V", 5);
            values.Add("I", 1);

            int sum = 0, i = 0;

            while(i < s.Length)
            {
                string currentSymbol = s.Substring(i, i + 1);
                int currentValue = values[currentSymbol];
                int nextValue = 0;
                if (i + 1 < s.Length)
                {
                    string nextSymbol = s.Substring(i + 1);
                    nextValue = values[nextSymbol];
                }

                if (currentValue < nextValue)
                {
                    sum += (nextValue - currentValue);
                    i += 2;
                }
                else
                {
                    sum += currentValue;
                    i += 1;
                }
            }

            return sum;
        } 

    }
}
