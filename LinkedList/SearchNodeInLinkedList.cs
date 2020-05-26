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