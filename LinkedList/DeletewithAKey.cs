// this will delete from the list with a provided key 
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
        
        public void DeleteNode(int key)
        {
            /* Given a key, deletes the first occurrence of key in linked list */
            // store head node
            Node temp = head;
            Node prev = null;

            // if head node itself holds the key to be deleted
            if (temp != null && temp.data == key)
            {
                head = temp.next; // change head
                return;
            }

            // search for the key to be deleted, keep track of the
            // previous node as we need to change temp.next
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            // if key was not present in the linked list return
            if (temp == null)
            {
                return;
            }

            // unlink the node from the list
            prev.next = temp.next;
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

                Console.Write("Created Linked list is: ");
                Linkedlist.PrintList();

                Linkedlist.DeleteNode(1);
                Console.WriteLine();
                Console.Write("Created Linked list is: ");
                Linkedlist.PrintList();
            }

        }
    }

}
