/*
    Write a function that reverses a string. The input string is given as an array of characters char[].
    Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    You may assume all the characters consist of printable ascii characters.
 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    { // delete Node from a linked list
        public void ReverseString(char[] s)
        {
            int n = s.Length;
            int i = 0, j = n - 1;

            while (i < j)
            {
                if(s[i] != s[j])
                {
                    // swap
                    Swap(s, i, j);
                }
                i++;
                j--;
            }
        }

        private void Swap(char[] s, int start, int end)
        {
            char tmp = s[start];
            s[start] = s[end];
            s[end] = tmp;
        }
    }
}
