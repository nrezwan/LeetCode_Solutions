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
    public ListNode SwapPairs(ListNode head) {
        if(head == null) return null;
        if(head.next == null) return head;

        ListNode d1 = new ListNode(0);
        var prev = d1;
        d1.next = head;
        var first = head;

        while(first != null && first.next !=null){
            var second = first.next;

            first.next = second.next;
            second.next = first;
            prev.next = second;
            prev = first;
            first = prev.next;
        }

        return d1.next;
    }
}