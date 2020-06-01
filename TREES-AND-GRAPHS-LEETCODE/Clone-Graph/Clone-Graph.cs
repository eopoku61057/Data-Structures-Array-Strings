using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure
{
    public class SortedZeros
    {
        public Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
        public Node CloneGraph(Node node)
        {   // Time complexity: 0(N)
            // Space complexity: 0(N)
            if (node == null) { return node; }

            // if the node was already visited before return the clone from the visited dictionary
            if(visited.ContainsKey(node))
            {
                return visited.GetValueOrDefault(node);
            }

            // Create a clone for the given node, Note that we don't have cloned neigbors as of now hence []
            Node cloneNode = new Node(node.val, new List<Node>());
            // the key is the original node and value being the clone node

            visited.Add(node, cloneNode);

            //Iterate through the neigbors to generate their clones and prepare a list of cloned neigbors to be added to the clones node
            foreach (Node x in node.neighbors)
            {
                cloneNode.neighbors.Add(CloneGraph(x));
            }
            return cloneNode;
        }
    }
}
