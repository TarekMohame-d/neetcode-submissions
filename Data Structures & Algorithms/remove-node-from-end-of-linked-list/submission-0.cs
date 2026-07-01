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

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head.next == null)
            return null;

        int i = n;
        ListNode ptr = head;

        while (i > 0) {
            ptr = ptr.next;
            i--;
        }

        if (ptr == null)
            return head.next;

        ListNode prev = null;

        while (ptr != null) {
            prev = prev == null ? head : prev.next;
            ptr = ptr.next;
        }

        prev.next = prev.next.next;

        return head;
    }
}
