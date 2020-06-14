using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class NumMatrix
    {
        public string alienOrder(string[] words)
        {
            int[] indegree = new int[26];
            Dictionary<char, List<char>> g = new Dictionary<char, List<char>>();
            BuildGraph(g, words, indegree);

            return BFS(g, indegree);
        }

        private string BFS(Dictionary<char, List<char>> g, int[] indegree)
        {
            StringBuilder sb = new StringBuilder();
            int totalChars = g.Count();
            Queue<char> queue = new Queue<char>();

            foreach (char c in g.Keys)
            {
                if (indegree[c - 'a'] == 0)
                {
                    sb.Append(c);
                    queue.Enqueue(c);
                }
            }

            while (queue.Count > 0)
            {
                char curr = queue.Peek();
                if (g.GetValueOrDefault(curr) != null || g.GetValueOrDefault(curr).Count == 0) continue;

                foreach (char neighbor in g.GetValueOrDefault(curr))
                {
                    indegree[neighbor - 'a']--;
                    if (indegree[neighbor - 'a'] == 0)
                    {
                        queue.Enqueue(neighbor);
                        sb.Append(neighbor);
                    }
                }
            }

            return sb.Length == totalChars ? sb.ToString() : "";
        }

        private void BuildGraph(Dictionary<char, List<char>> g, string[] words, int[] indegree)
        {
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (!g.ContainsKey(c))
                    {
                        g.Add(c, new List<char>());
                    }
                    
                }
            }

            for (int i = 1; i < words.Length; i++)
            {
                string first = words[i - 1];
                string second = words[i];
                int len = Math.Min(first.Length, second.Length);

                for (int j = 0; j < len; j++)
                {
                    if(first[j] != second[j])
                    {
                        char out1 = first[j];
                        char in1 = second[j];

                        if (!g.GetValueOrDefault(out1).Contains(in1))
                        {
                            g.GetValueOrDefault(out1).Add(in1);
                            indegree[in1 - 'a']++;
                        }
                        break;
                    }
                }
            }
        }
    }
}
