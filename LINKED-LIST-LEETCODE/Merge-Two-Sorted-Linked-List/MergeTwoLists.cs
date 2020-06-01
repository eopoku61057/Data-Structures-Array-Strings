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
        // Time complexity is 0(n+m) space complexity 0(1)
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode newList = new ListNode(-1);
            ListNode curr = newList;

            while (l1 != null && l2 != null)
            {
                // compare the list and start filling the newlist
                if (l1.val <= l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    curr.next = l2;
                    l2 = l2.next;
                }
                curr = curr.next;
            }
            curr.next = l1 == null ? l2 : l1;
            return newList.next;
        }
    }
}
