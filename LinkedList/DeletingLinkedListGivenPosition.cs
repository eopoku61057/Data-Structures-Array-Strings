// this method delete a linked when the position is given

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedListMethods
    {
        public Node head; // head of list

        public class Node
        {
            public int data;
            public Node next;

            // constructor
            public Node(int d)
            { data = d; next = null; }
        }
        
        public void DeleteNode(int position)
        {
            /* Delete a node in linked list at a given position */
            /* Given a reference (pointer to pointer) to the head of a list 
            and a position, deletes the node at the given position */

            // If Linked list empty return
            if (head == null)
            {
                return;
            }

            // store head
            Node temp = head;

            // if head needs to be removed
            if (position == 0)
            {
                head = temp.next; // change head
                return;
            }

            // find previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            // if position is more than number of nodes
            if(temp == null || temp.next == null)
            {
                return;
            }

            // Node temp->next is the node to be deleted
            // store pointer to the next of node to be deleted
            Node next = temp.next.next;

            temp.next = next; // unlink the deleted node from list

        }

        public void push(int new_data)
        {
            Node new_Node = new Node(new_data);
            new_Node.next = head;
            head = new_Node;
        }

        public void PrintList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                LinkedListMethods Linkedlist = new LinkedListMethods();

                Linkedlist.push(7);
                Linkedlist.push(1);
                Linkedlist.push(3);
                Linkedlist.push(2);
                Linkedlist.push(8);

                Console.Write("Linked list before deletion is: ");
                Linkedlist.PrintList();

                Linkedlist.DeleteNode(4);
                Console.WriteLine();
                Console.Write("Linked list after deletion is: ");
                Linkedlist.PrintList();
            }

        }
    }
}
