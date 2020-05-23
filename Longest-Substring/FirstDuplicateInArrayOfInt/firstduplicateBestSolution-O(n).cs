using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        // this is the best solution since it has Big O(n) thus linear and not making less use of use
        public int FirstDuplicate(int[] dupArray)
        {
            // { 2, 1, 3, 5, 3, 2 };
            // it check the int values from index zero, and walk by the index and subtract -1 of that index, 
            // we do a check to see if the variable is already negative, if it is we return it, if not we continue the same thing above
            for (int i = 0; i < dupArray.Length; i++)
            {
                if (dupArray[Math.Abs(dupArray[i]) - 1] < 0)
                {
                    return Math.Abs(dupArray[i]);
                } 
                else
                {
                    dupArray[Math.Abs(dupArray[i]) - 1] = -dupArray[Math.Abs(dupArray[i]) - 1];
                }
            }
            return -1;
        }
    }
}
