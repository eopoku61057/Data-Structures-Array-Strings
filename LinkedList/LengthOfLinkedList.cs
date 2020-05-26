// Finding the length of a linked list

        public int GetCount()
        {
            /* Returns count of nodes in linked list */
            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }