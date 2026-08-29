# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def rotateRight(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if head is None:
            return None

        if head.next is None:
            return head
        
        length = 1
        curr = head
        while curr.next is not None:
            curr = curr.next
            length += 1
        
        k = k % length
        if k == 0:
            return head
        
        while k > 0:
            prev = head
            while prev.next.next is not None:
                prev = prev.next
            
            tail = prev.next
            tail.next = head
            prev.next = None
            head = tail
            k-=1

        return head

         