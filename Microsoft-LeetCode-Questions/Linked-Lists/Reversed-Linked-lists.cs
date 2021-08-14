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
    public ListNode ReverseList(ListNode head)
    {
        if (head == null) return head;

        ListNode nodetoReturn = null, tmp;
        while (head != null)
        {
            tmp = head.next;

            head.next = nodetoReturn;
            nodetoReturn = head;
            head = tmp;
        }
        return nodetoReturn;
    }
}