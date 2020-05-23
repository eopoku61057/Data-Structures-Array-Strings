using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class FirstDuplicate
    {
        // this sloution uses Big O(n) which is linear and that is better than the previous solution 
        // which was using Big O(n^2), HashSet - the type of elemets in the hash set
        public int FirstDuplicate(int[] dupArray)
        {
            HashSet<int> seen = new HashSet<int>();  // declare an empty hash set of int, 
            // we will fill it with the array and check to see if the number to be added is already in the set or not
            // if it is already in the set then we return the number since that is our first duplicate
            // if not we add the number

            for (int i = 0; i < dupArray.Length; i++)
            {
                if (seen.Contains(dupArray[i]))
                {
                    return dupArray[i];
                }
                else
                {
                    seen.Add(dupArray[i]);
                }
            }
            return -1;
        }
    }
}
