using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        /*
            Time Complexity: O(NK \log K)O(NKlogK), where NN is the length of strs, and KK is the maximum length of a string in strs. 
            The outer loop has complexity O(N)O(N) as we iterate through each string. Then, we sort each string in O(K \log K)O(KlogK) time.
            Space Complexity: O(NK)O(NK), the total information content stored in ans.

         */
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagrams = new List<IList<string>>();
            var anagramTable = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                var sortedStr = string.Concat(str.OrderBy(c => c));
                string.Concat(sortedStr.OrderBy(c => c));

                if(anagramTable.ContainsKey(sortedStr))
                {
                    anagramTable[sortedStr].Add(str);
                }
                else
                {
                    var values = new List<string>();
                    values.Add(str);
                    anagramTable.Add(sortedStr, values);
                }
            }

            foreach (var pair in anagramTable)
            {
                anagrams.Add(pair.Value);
            }
            return anagrams;
        }

        static void Main(string[] args)
        {
            var data = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var obj = new SortedZeros();
            IList<IList<string>> i = obj.GroupAnagrams(data);

            foreach (var r in i)
            {
                foreach (var d in r)
                {
                    Console.Write(d + " ");
                }
            }
        }
    }
}
