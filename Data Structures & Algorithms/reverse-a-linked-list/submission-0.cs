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
    public ListNode ReverseList(ListNode head) {
        if (head == null)
            return null;

        var ptr = head.next;
        head.next = null;
        while (ptr != null) {
            var t = ptr.next;
            ptr.next = head;
            head = ptr;
            ptr = t;
        }
        return head;
    }
}
