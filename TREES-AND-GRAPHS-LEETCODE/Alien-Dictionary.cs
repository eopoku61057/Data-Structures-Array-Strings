using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        // Time complexity: 0(C)
        // space complexity: 0(1)
        private Dictionary<char, List<char>> reverseAdjList = new Dictionary<char, List<char>>();
        private Dictionary<char, Boolean> seen = new Dictionary<char, bool>();
        private StringBuilder output = new StringBuilder();
        public string AlienOrder(string[] words)
        {
            //step 0: put all unique letters into reverseAdjList as keys
            foreach (var word in words)
            {
                foreach(var c in word.ToCharArray())
                {
                    reverseAdjList.Add(c, new List<char>());
                }
            }

            // step1: Find all edges and add reverse edges to reverseAdjList.
            for (int i = 0; i < words.Length - 1; i++)
            {
                string word1 = words[i];
                string word2 = words[i + 1];
                // check that word2 is not prefix of word1
                if (word1.Length > word2.Length && word1.StartsWith(word2))
                {
                    return "";
                }
                // Find the first non match and insert the corresponding relation
                for (int j = 0; j < Math.Min(word1.Length, word2.Length); j++)
                {
                    if(word1[j] != word2[j])
                    {
                        reverseAdjList.GetValueOrDefault(word2[j]).Add(word1[j]);
                        break;
                    }
                }
            }

            // step 2: DFS to build up the output list
            foreach (var i in words)
            {
                foreach (var x in i)
                {
                    if (reverseAdjList.ContainsKey(i[x]))
                    {
                        bool result = dfs(x);
                        if (!result) return "";
                    }
                }
            }

            if (output.Length < reverseAdjList.Count())
            {
                return "";
            }
            return output.ToString();

        }

        // return true if no cycles detected
        private bool dfs(char x)
        {
            if (seen.ContainsKey(x))
            {
                return seen.GetValueOrDefault(x); // if this node was grey (false), a cycle was detected
            }
            seen.Add(x, false);
            foreach (var next in reverseAdjList.GetValueOrDefault(x))
            {
                bool result = dfs(next);
                if (!result) return false;
            }
            seen.Add(x, false);
            output.Append(x);
            return true;
        }
    }
}
