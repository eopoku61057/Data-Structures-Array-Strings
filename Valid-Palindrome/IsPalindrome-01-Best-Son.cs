public class Solution
{
    public bool IsPalindrome(string s)
    {
        int start = 0; int end = s.Length - 1;


        while (start < end)
        {
            var s1 = s[start];

            var s2 = s[end];

            bool s1Valid = IsValid(s1);

            bool s2Valid = IsValid(s2);

            if (s1Valid && s2Valid)
            {
                if (!s1.ToString().ToLower().Equals(s2.ToString().ToLower()))
                {
                    return false;
                }
                start++;
                end--;
            }
            else if (!s1Valid)
            {
                start++;
            }
            else
            {
                end--;
            }
        }

        return true;

    }
    private bool IsValid(char ch)
    {
        return char.IsLetterOrDigit(ch);
    }
}