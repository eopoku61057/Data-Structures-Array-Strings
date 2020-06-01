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

        public Node getClonedNode(Node node)
        {
            //if the node exists the
            if (node != null)
            {
                // check if the node is visited
                if (this.visited.ContainsKey(node))
                {
                    return this.visited.GetValueOrDefault(node);
                }
                else
                {
                    // otherwise create a new node, add to the dictionary and return it
                    this.visited.Add(node, new Node(node.val));
                    return this.visited.GetValueOrDefault(node);
                }
            }
            return null;
        }
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node oldNode = head;

            // creating the new head node.
            Node newNode = new Node(oldNode.val);
            this.visited.Add(oldNode, newNode);

            // Iterate on the linked list untill all node are cloned
            while (oldNode != null)
            {
                // get the clones of the nodes referenced by random and next pointers.
                newNode.random = this.getClonedNode(oldNode.random);
                newNode.next = this.getClonedNode(oldNode.next);

                // move one step ahead in the linked list
                oldNode = oldNode.next;
                newNode = newNode.next;
            }

            return this.visited.GetValueOrDefault(head);

        }
    }
}
