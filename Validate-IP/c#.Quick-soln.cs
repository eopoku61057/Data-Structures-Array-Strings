public string ValidIPAddress(string IP) {
    var hs = new HashSet<string>();
    hs.Add("0123456789abcdefABCDEF");
    var arrv4 = IP.Split(".");
    var arrv6 = IP.Split(":");

    if (arrv4.Length == 4) {
        foreach (string s in arrv4) {
            // check that the substring is a number
            int num;
            if (int.TryParse(s, out num) == false) return "Neither";
            // check number between 0 and 255
            if (num < 0 || num > 255) return "Neither";
            // check doesnt have a leading 0
            if (num.ToString() != s) return "Neither";
        }
        return "IPv4";
    }
    else if (arrv6.Length == 8) {
        foreach (var s in arrv6) {
            // check arr.Length, shoould be between 1 and 4 chars
            if (s.Length < 1 || s.Length > 4) return "Neither";
            
            // check char between 0 - 9, a - z, A - Z
            foreach (var c in s) {
                if (!hs.Contains(c)) return "Neither";
            }
        }
        return "IPv6";
    }
    return "Neither";
}