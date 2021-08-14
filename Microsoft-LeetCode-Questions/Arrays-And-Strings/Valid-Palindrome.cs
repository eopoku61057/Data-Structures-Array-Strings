if (s.Length == 0)
    return false;

int l = 0, r = s.Length - 1;
while (l < r)
{
    var s1 = s[l];
    var s2 = s[r];

    bool s1Valid = IsValid(s1);
    bool s2Valid = IsValid(s2);
    if (s1Valid && s2Valid)
    {
        if (!(s1.ToString().ToLower().Equal(s2.Tostring().Lower())))
        {
            return false;
        }
        l++;
        r--;
    }
    if (!s1Valid)
    {
        l++;
    }
    else if (!s2Valid)
    {
        r--;
    }
}
return true;
        
    }
    private bool IsValid(char c)
{
    return IsLetterOrChar(c);
}