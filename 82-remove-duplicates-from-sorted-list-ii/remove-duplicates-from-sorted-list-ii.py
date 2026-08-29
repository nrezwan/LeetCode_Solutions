# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        dummy = ListNode(0)
        dummy.next = head
        prev = dummy
        while prev.next is not None:
            curr = prev.next
            if curr.next is not None and curr.val == curr.next.val:
                while prev.next is not None and prev.next.val == curr.val:
                    prev.next = prev.next.next
            else:
                prev = prev.next
        
        return dummy.next
            

