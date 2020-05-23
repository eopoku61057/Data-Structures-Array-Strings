using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class FirstDuplicate
    {
        public int FirstDuplicate(int[] dupArray)
        {
            // this method use O(n^2) which is not efficient
            // we need a better solution to the problem since as the data gets larger (n) thus
            // it's going to take more time to do this
            // { 2, 1, 3, 5, 3, 2 };
            int dupArrayLength = dupArray.Length;
            int min_Index = 0;

            for (int i = 0; i < dupArrayLength; i++)
            {
                for (int j = i + 1; j < dupArrayLength; j++)
                {
                    if (dupArray[i] == dupArray[j])
                    {
                        dupArrayLength = Minvalue(dupArrayLength, j); // you can use Math.min to get the minimum value here as well
                    }
                }
            }

            if (dupArrayLength == dupArray.Length) return -1;
            else return dupArray[dupArrayLength];
        }

        private int Minvalue(int firstInt, int SecondInt)
        {
            if (firstInt < SecondInt)
            {
                return firstInt;
            }
            else return SecondInt;
        }
    }
}
