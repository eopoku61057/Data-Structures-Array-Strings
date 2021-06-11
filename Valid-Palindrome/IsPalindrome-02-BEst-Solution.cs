public class Solution
{
    public bool ValidPalindrome(string s)
    {
        return IsPalindrome(s, 0, s.Length - 1, false);
    }

    private bool IsPalindrome(string s, int start, int end, bool hasError)
    {
        while (start < end)
        {
            if (s[start].Equals(s[end]))
            {
                start++;
                end--;
                continue;
            }

            if (hasError) return false;
            return IsPalindrome(s, start + 1, end, true) || IsPalindrome(s, start, end - 1, true);
        }

        return true;
    }
}