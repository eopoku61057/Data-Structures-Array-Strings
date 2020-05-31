using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    {
        public string ValidIPV4(string IP)
        {
            string pattern = "(\\.)";
            Regex regex = new Regex(pattern);
            string[] nums = Regex.Split(IP, pattern);

            foreach (string x in nums)
            {
                // Validate integer in range (0, 255);
                //1. length of chunk is between 1 and 3
                if (x.Length == 0 || x.Length > 3) return "Neither";

                //3. Only digits are allowed
                foreach (char w in x.ToCharArray())
                {
                    // 2. no extra leading zeros
                    //if (w == '0') return "Neither";
                    if (!char.IsDigit(w)) return "Neither";
                }

                // 4. less than 255
                // if (int.Parse(x) > 255) return "Neither";
            }
            return "IPv4";
        }

        public string ValidIPV6(string IP)
        {
            string[] nums = IP.Split(":", 1);
            string hexdigits = "0123456789abcdefABCDEF";
            foreach (string x in nums)
            {
                // validate hexadecimaol in range (0, 2**16);
                // 1. atleast one and not more than 4 hedigits in one chunk
                if (x.Length == 0 || x.Length > 4) return "Neither";

                // 2. Only hexdigits are allowed: 0 - 9, a - f, A - F
                foreach (char ch in x.ToCharArray())
                {
                    if (hexdigits.IndexOf(ch) == -1) return "Neither";
                }
            }
            return "IPV6";
        }

        public string validIPAddress(string IP)
        {
            if (IP.Where(ch => ch == '.').Select(y => y).Count() == 3)
            {
                return ValidIPV4(IP);
            }
            else if (IP.Where(ch => ch == ':').Select(y => y).Count() == 3)
            {
                return ValidIPV6(IP);
            }
            return "Neither"; 
        }
    }
}
