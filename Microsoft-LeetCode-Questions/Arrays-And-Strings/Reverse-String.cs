public class Solution
{
    public void ReverseString(char[] s)
    {
        int start = 0, end = s.Length - 1;
        while (start < end)
        {
            Swap(s, start, end);
            start++;
            end--;
        }
    }
    private void Swap(char[] s, int i, int j)
    {
        char tmp = s[i];
        s[i] = s[j];
        s[j] = tmp;
    }
}