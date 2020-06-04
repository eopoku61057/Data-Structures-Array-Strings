using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public bool IsBipartite(int[][] graph)
        {
            int n = graph.Length;
            int[] color = new int[n];
            Array.Fill(color, -1);

            for(int start = 0; start < n; start++)
            {
                if (color[start] == -1)
                {
                    Stack<int> stack = new Stack<int>();
                    stack.Push(start);
                    color[start] = 0;

                    while(!stack.Any())
                    {
                        int node = stack.Pop();
                        foreach(var nei in graph[node])
                        {
                            if(color[nei] == -1)
                            {
                                stack.Push(nei);
                                color[nei] = color[node] ^ 1;
                            } else if (color[nei] == color[node])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
