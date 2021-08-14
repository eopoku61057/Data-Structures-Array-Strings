// java solution 
class Solution
{
    public void reverseWords(char[] s)
    {
        int n = s.length - 1;
        reverse(0, n, s);

        for (int i = 0; i < s.length; i++)
        {
            int start = i;
            while (i < s.length && s[i] != ' ') i++;

            reverse(start, i - 1, s);
        }

        return;
    }

    private void reverse(int start, int end, char[] s)
    {
        while (start < end)
        {
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            start++;
            end--;
        }
        return;
    }
}