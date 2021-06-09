class Program
{
    static void Main(string[] args)
    {
        string test = "172.16.254.1";
        string get = ValidIP(test);
    }

    private static string ValidIP(string IP)
    {
        if (IP.Length == 0)
            return "NEITHER";
        bool validIPV4 = true;
        bool validIPV6 = true;
        if (IP.StartsWith(".") || IP.StartsWith("0") || IP.EndsWith("."))
            validIPV4 = false;
        if (IP.StartsWith(":") || IP.EndsWith(":"))
            validIPV6 = false;
        string[] Segments;

        if (validIPV4)
        {
            Segments = IP.Split(".");
            if (Segments.Length != 4)
                validIPV4 = false;
            foreach (var seg in Segments)
            {
                if (validIPV4)
                {
                    validIPV4 = checkIP4Seg(seg);
                }
            }
        }

        if (validIPV6)
        {
            Segments = IP.Split(":");
            if (Segments.Length != 8)
                validIPV6 = false;
            foreach (var seg in Segments)
            {
                if (validIPV6)
                {
                    validIPV6 = checkIPV6Seg(seg);
                }
            }
        }
        if (validIPV4)
            return "IPV4";
        else if (validIPV6)
            return "IPV6";
        else return "NEITHER";

    }

    private static bool checkIPV6Seg(string seg)
    {
        if (seg.Length < 1 || seg.Length > 4)
            return false;
        string hexdigits = "0123456789abcdefABCDEF";
        foreach (var tt in seg)
        {
            if (!hexdigits.Contains(tt))
                return false;
        }
        return true;
    }

    private static bool checkIP4Seg(string seg)
    {
        int i = 0;
        while (i <= seg.Length - 1 && seg[i] == ' ')
        {
            i++;
        }
        if (i == seg.Length)
            return false;
        if (seg.StartsWith("0") && seg.Length > 1)
            return false;
        int digit = 0;
        while (i <= seg.Length - 1 && seg[i] != ' ')
        {
            char c = seg[i];
            if (c < '0' || c > '9')
                return false;
            digit = digit * 10 + (c - '0');
            if (digit > 255)
                return false;
            i++;
        }

        //take care of trailing zeroes
        while (i <= seg.Length - 1)
        {
            char c = seg[i];
            if (c != ' ')
                return false;
            i++;
        }
        return true;
    }
}