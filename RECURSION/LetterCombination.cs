/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        // Time complexity: 0(3^N * 4^m)
        // Space Complexity: 0(3^N * 4^m)
        private Dictionary<string, string> phone = new Dictionary<string, string>();
        private IList<string> output = new List<string>();
        public void BackTrack(string combination, string next_digits)
        {
            phone.Add("2", "abc");
            phone.Add("3", "def");
            phone.Add("4", "ghi");
            phone.Add("5", "jkl");
            phone.Add("6", "mno");
            phone.Add("7", "pqrs");
            phone.Add("8", "tuv");
            phone.Add("9", "wxyz");

            // if there is no more digits to check
            if (next_digits.Length == 0)
            {
                output.Add(combination);
            }
            else
            {
                // if there are still digits to check
                //Iterate over all the letters which map the next available digit
                string digit = next_digits.Substring(0, 1);
                string letters = phone.GetValueOrDefault(digit);

                foreach (char letter in letters)
                {
                    //append the current letter to the combination and proceed to the next digits
                    BackTrack(combination + letter, next_digits.Substring(1));
                }
            }


        }

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length != 0)
            {
                BackTrack("", digits);
            }
            return output;
        }
    }
}
