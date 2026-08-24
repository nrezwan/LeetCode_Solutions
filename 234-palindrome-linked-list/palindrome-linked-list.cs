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
    public bool IsPalindrome(ListNode head) {
        if(head.next == null)
            return true;
        else{
            var fast = head;
            var slow = head;
            while(fast != null && fast.next !=null){
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode current;
            if(fast != null){
                current = slow.next;
            }
            else{
                current = slow;
            }
            ListNode prev = null;
            while(current != null){
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            var firstHalf = head;
            var secondHalf = prev;
            
            while (secondHalf != null) {
                if (firstHalf.val != secondHalf.val) {
                    return false;
                }
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }
            
            return true;
        }
    }
}
