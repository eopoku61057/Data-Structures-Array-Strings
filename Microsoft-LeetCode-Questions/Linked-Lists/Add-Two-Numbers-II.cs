/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode p1 = reverse(l1);
        ListNode p2 = reverse(l2);
        ListNode finalNode = new ListNode(0);
        ListNode curr = finalNode;

        int carry = 0;
        while (p1 != null || p2 != null)
        {
            int v1 = (p1 != null) ? p1.val : 0;
            int v2 = (p2 != null) ? p2.val : 0;
            int sum = carry + v1 + v2;
            carry = sum / 10;
            int digit = sum % 10;

            ListNode c = new ListNode(digit);
            curr.next = c;
            curr = curr.next;
            if (p1 != null) p1 = p1.next;
            if (p2 != null) p2 = p2.next;
        }
        curr.next = (p1 == null) ? p2 : p1;
        if (carry > 0)
        {
            ListNode c = new ListNode(carry);
            curr.next = c;
        }
        finalNode.next = reverse(finalNode.next);
        return finalNode.next;
    }
    private ListNode reverse(ListNode node)
    {
        ListNode finalnode = null, tmp;
        while (node != null)
        {
            tmp = node.next;

            node.next = finalnode;
            finalnode = node;
            node = tmp;
        }
        return finalnode;
    }
}