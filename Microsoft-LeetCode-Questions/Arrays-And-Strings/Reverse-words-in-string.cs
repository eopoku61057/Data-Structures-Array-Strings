public static string ReverseWords(string s)
{
    if (string.IsNullOrEmpty(s))
        return "";
    int j = s.Length - 1;
    StringBuilder data = new StringBuilder();
    while (j >= 0)
    {
        while (j >= 0 && s[j] == ' ')
            j--;

        int k = j;
        while (j >= 0 && s[j] != ' ')
            j--;
        if (j != k)
        {
            var sub = s.Substring(j + 1, k + 1);
            data.Append(sub + " ");
        }

    }
    data.Length = data.Length - 1;
    return data.ToString();
}

// better linq solution - one line of code 
public class Solution
{
    public string ReverseWords(string s)
    {
        return s.Split(" ").Select(x => x).Where(x => x != "").Aggregate((x, y) => y + " " + x);

    }
}