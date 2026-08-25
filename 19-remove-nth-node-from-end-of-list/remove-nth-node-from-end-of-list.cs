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
        if(head == null) 
            return null;
        
        var fast = head;
        var slow = head;
        ListNode d1 = new ListNode(0,null);
        d1.next = head;
        
        ListNode prev = d1;
        ListNode next;
        var count = 0;

        while(fast != null){
            fast = fast.next;
            count++;
            if(count>n){
                slow = slow.next;
                prev = prev.next;
            }
        }

        //if(slow.val == n){
            prev.next = slow.next;
            slow.next = null;
        //}
        return d1.next;
    }
}