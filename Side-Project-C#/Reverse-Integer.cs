/*
 Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
 */

 public class Solution {
    public int Reverse(int x) {
        int rev = 0;

        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;

            if (rev > Int.MaxValue / 10 || (rev == Int.MaxValue / 10 && pop > 7)) return 0;
            if (rev < Int.MaxValue / 10 || (rev == Int.MaxValue / 10 && pop < -8)) return 0;
            rev = rev * 10 + pop;
        }
        return rev;
    }
}