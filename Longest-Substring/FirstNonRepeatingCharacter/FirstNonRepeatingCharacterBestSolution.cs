using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class FirstNonRepeatingCharacter
    {
        // using dictionary I am able to better my solution, this time time complexity is Big O(n) linear which is better than the previous one
        // I declare a dictionary object with key of the char of the string and anytime I loop over and find a repeated char I increase the value by 1
        // else if its new i add the char and set the value to one, 
        // at the end, I use for loop to loop through the dictionary and find the first value that has only one key and return 
        public char FirstNonRepeatingCharacter(string s)
        {
            Dictionary<char, int> data = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if(data.ContainsKey(c))
                {
                    data[c] += 1;
                }
                else
                {
                    data.Add(c, 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (data.GetValueOrDefault(c) == 1)
                {
                    return c;
                }
            }
            return '_';
        }
    }
}
