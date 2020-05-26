/* I will show the tree way we can insert into single Linked List */

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedListMethods
    {
        // Time complexity of push() is O(1) as it does constant amount of work.
        /* Inserts a new Node at front of the list. */
        public void push(SingleLinkedList singlyList, int new_data)
        {
            // allocate the node and put in data
            Node new_node = new Node(new_data);

            // make next of new node as head
            new_node.next = singlyList.head;

            // make the head point to new Node
            singlyList.head = new_node;
        }

        public void InsertAfter(Node prev_node, int new_data)
        {
            // Time complexity of insertAfter() is O(1) as it does constant amount of work.
            /* Inserts a new node after the given prev_node. */
            // first check if prev_node == null
            if (prev_node == null)
            {
                Console.WriteLine("The previous node cannot be null");
                return;
            }

            /* Allocate newnode and put in data */
            Node new_Node = new Node(new_data);

            // make next of new node as next of prev_node
            new_Node.next = prev_node.next;

            // make next of prev_node as new_node
            prev_node.next = new_Node;
        }

        public void Append(SingleLinkedList data, int new_data)
        {
            /* Time complexity of append is O(n) where n is the number of nodes in linked list. 
             * Since there is a loop from head to end, the function does O(n) work.
             * This method can also be optimized to work in O(1) by keeping an extra pointer to tail of linked list/ 
            */
            /* Appends a new node at the end. */
            // Allocate new_Node, put in the data and set next to null
            Node new_Node = new Node(new_data);

            // if linked list is empty, then make the new node as head
            if(data.head == null)
            {
                data.head = new Node(new_data);
                return;
            }

            // new_Node will be the last node so set the next to null
            new_Node.next = null;

            /* Else traverse till the last node */
            Node last = data.head;
            while(last.next != null)
            {
                last = last.next;
            }

            last.next = new_Node;
            return;
        }
    }
}
