/**
 * The Read4 API is defined in the parent class Reader4.
 *     int Read4(char[] buf4);
 */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
    char[] tempBuf = new char[4];
    int buffCount = 0;
    int buffPtr = 0;
    public int Read(char[] buf, int n) 
    {
        if(n <= 0) return 0;
                
        int ptr = 0;       
        while(ptr < n)
        {
            if(buffPtr == 0)
            {
                buffCount = Read4(tempBuf);            
            }
            
            if(buffCount == 0)
                break;
            
            while(ptr < n && buffPtr < buffCount)
                buf[ptr++] = tempBuf[buffPtr++];
            
            if(buffPtr >= buffCount) buffPtr = 0;
        }
        
        return ptr;
    }
}