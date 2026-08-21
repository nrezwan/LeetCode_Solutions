public class Solution {
    // ListNode class for our linked list
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
    
    public bool IsPalindrome(int x) {
        // Negative numbers are not palindromes
        if (x < 0) return false;
        
        // Convert number to digits
        List<int> digits = new List<int>();
        int temp = x;
        while (temp > 0) {
            digits.Add(temp % 10);
            temp /= 10;
        }
        // Handle x = 0
        if (digits.Count == 0) {
            digits.Add(0);
        }
        
        // Create forward linked list
        ListNode forwardHead = CreateLinkedList(digits);
        
        // Create backward linked list
        List<int> reversedDigits = new List<int>(digits);
        reversedDigits.Reverse();
        ListNode backwardHead = CreateLinkedList(reversedDigits);
        
        // Compare the two linked lists
        return CompareLinkedLists(forwardHead, backwardHead);
    }
    
    private ListNode CreateLinkedList(List<int> digits) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        foreach (int digit in digits) {
            current.next = new ListNode(digit);
            current = current.next;
        }
        
        return dummy.next;
    }
    
    private bool CompareLinkedLists(ListNode list1, ListNode list2) {
        ListNode current1 = list1;
        ListNode current2 = list2;
        
        while (current1 != null && current2 != null) {
            if (current1.val != current2.val) {
                return false;
            }
            current1 = current1.next;
            current2 = current2.next;
        }
        
        // Both lists should be same length
        return current1 == null && current2 == null;
    }
}