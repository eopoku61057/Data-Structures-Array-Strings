using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public int Read(char[] buf, int n)
        {
            Boolean eof = false;  // end of file flag
            int total = 0;        // total bytes have read
            char[] tmp = new char[4]; // temp buffer

            while (!eof && total < n)
            {
                int count = Read4(tmp);

                // check if it's the end of the file
                eof = count < 4;

                // get the actual count
                count = Math.Min(count, n - total);

                //copy from temp buffer to buff
                for (int i = 0; i < count; i++)
                {
                    buf[total++] = tmp[i];
                }
            }
            return total;
        }

        private int Read4(char[] tmp)
        {
            throw new NotImplementedException();
        }
    }
}
