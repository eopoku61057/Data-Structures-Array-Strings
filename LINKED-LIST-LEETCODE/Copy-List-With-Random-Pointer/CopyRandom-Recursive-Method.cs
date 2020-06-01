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
        // Time Complexity: 0(N) Space complexity: 0(N)
        // Dictionary which holds old nodesas keys and new nodes as its values
        public Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            // if we already processed the current node, then we simply return the cloned version of it
            if(this.visited.ContainsKey(head))
            {
                return this.visited.GetValueOrDefault(head);
            }

            // Create a new node with the value same as old node. (i.e. copy the node)
            Node node = new Node(head.val);

            // Save this value in the hash map. This is needed since there might be
            // loops during traversal due to randomness of random pointers and this would help us avoid
            // them.
            this.visited.Add(head, node);

            // Recursively copy the remaining linked list starting once from the next pointer and then from
            // the random pointer.
            // Thus we have two independent recursive calls.
            // Finally we update the next and random pointers for the new node created.
            node.next = this.CopyRandomList(head.next);
            node.random = this.CopyRandomList(head.random);

            return node;

        }
    }
}
