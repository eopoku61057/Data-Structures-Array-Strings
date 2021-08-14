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
    private ListNode combined = new ListNode();
    public ListNode MergeKLists(ListNode[] lists)
    {
        var sentinel = combined;

        var status = Step(lists);
        while (status)
        {
            status = Step(lists);
        }
        return sentinel.next;
    }

    private bool Step(ListNode[] lists)
    {
        bool hasmore = false;
        int min = int.MaxValue;
        for (var i = 0; i < lists.Length; i++)
        {
            if (lists[i] == null) continue;
            hasmore = true;

            min = Math.Min(min, lists[i].val);
        }
        if (!hasmore)
        {
            return false;
        }
        for (var i = 0; i < lists.Length; i++)
        {
            if (lists[i] == null) continue;

            if (lists[i].val == min)
            {
                combined.next = lists[i];
                combined = combined.next;
                lists[i] = lists[i].next;
            }
        }
        return true;
    }
}