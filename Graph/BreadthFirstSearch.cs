using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Graph
    {
        private int V; //no. of vertices
        private LinkedList<int>[] adj; // adjacency lists

        // constructor
        public Graph(int data)
        {
            V = data;
            adj = new LinkedList<int>[data];
            for (int i = 0; i < data; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        // function to add an edge into a graph
        public void AddEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }

        // prints BFS traversal from a given soruce s
        public void BFS(int s)
        {
            // Marke all vertices as not visited(By default set as false
            Boolean[] visited = new Boolean[V];

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            // Mark the current node as visited and enqueue it
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.Write(s + " ");

                // Get all adjacent vertices of the dequeued vertex s 
                // If a adjacent has not been visited, then mark it 
                // visited and enqueue it 

                LinkedList<int> i = adj[s];
                while(i.Contains(s))
                {
                    int n = i.First();
                    if (!visited[n])
                    {
                        visited[n] = true;
                        queue.Enqueue(n);
                    }
                }
             }
        }

        // Driver method to 
        public static void main(string[] args)
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine("Following is Breadth First Traversal " +
                               "(starting from vertex 2)");

            g.BFS(2);
        }
    }
}
