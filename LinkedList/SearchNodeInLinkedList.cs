        public bool search(Node head, int x)
        {
            // iterative serach
            Node curr = head;
            while (curr != null)
            {
                if (curr.data == x)
                {
                    return true; // data found
                }
                curr = curr.next;
            }
            return false; // data not found
        }

        public bool RecursiveSearch(Node head, int x)
        {
            // recursive search
            if (head == null)
            {
                return false;
            }

            if (head.data == x)
            {
                return true;
            }

            return RecursiveSearch(head.next, x);
        }

        /* Takes head pointer of the linked list and index  
        as arguments and return data at index*/
        static int GetNth( Node head, int n)  
        {  
            //Base Condition 
            if(head == null) 
                return -1; 
  
            int count = 0;  
      
            //if count equal too n return node.data  
            //Test Condition 
            if(count == n)  
                return head.data;  
      
            //recursively decrease n and increase  
            // head to next pointer  
             return GetNth(head.next, n - 1);  
        }  