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
        public ListNode AddTwoNumbers(ListNode n1, ListNode n2)
        {
            ListNode newNode = new ListNode(0);
            if (n1 == null || n2 == null)
            {
                return newNode;
            }

            while(n1 != null && n2 != null)
            {
                n1.val = n1.val + n2.val;
                // compute carry over
                if(n1.val == 10)
                {
                    n1.next.val += 1; 
                    newNode.val = 0;
                    newNode.next = new ListNode(0);
                }
                else
                {
                    newNode.val = n1.val;
                    newNode.next = new ListNode(0);
                }
                n1 = n1.next;
                n2 = n2.next;
            }

            if (n1 == null)
            {
                newNode.next = null;
            }

            return newNode;

        }
    }
}
