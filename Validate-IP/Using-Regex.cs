using System.Text.RegularExpressions;
public class Solution {
    public string ValidIPAddress(string IP) {
        if (Regex.IsMatch(IP, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
            return "IPv4";
        if (Regex.IsMatch(IP.ToUpper(), @"^(?:[A-F0-9]{1,4}:){7}[A-F0-9]{1,4}$"))
            return "IPv6";
        return "Neither";
    }
}