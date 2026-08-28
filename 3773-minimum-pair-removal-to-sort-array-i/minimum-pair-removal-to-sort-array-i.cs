public class Solution {
    private class Node
    {
        public int Value { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }
        
        public Node(int value)
        {
            Value = value;
        }
    }

    public int MinimumPairRemoval(int[] nums) {
        if (nums == null || nums.Length <= 1)
            return 0;
        
        Node head = null;
        Node tail = null;
        
        foreach (int num in nums)
        {
            Node newNode = new Node(num);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }
        
        int operations = 0;
        
        while (true)
        {
            bool isSorted = true;
            Node current = head;
            while (current != null && current.Next != null)
            {
                if (current.Value > current.Next.Value)
                {
                    isSorted = false;
                    break;
                }
                current = current.Next;
            }
            
            if (isSorted)
                return operations;
            
            int minSum = int.MaxValue;
            Node minNode = null;
            
            current = head;
            while (current != null && current.Next != null)
            {
                int sum = current.Value + current.Next.Value;
                if (sum < minSum)
                {
                    minSum = sum;
                    minNode = current;
                }
                current = current.Next;
            }

            Node mergedNode = new Node(minSum);
            
            if (minNode.Prev != null)
            {
                minNode.Prev.Next = mergedNode;
                mergedNode.Prev = minNode.Prev;
            }
            else
            {
                head = mergedNode;
            }
            
            if (minNode.Next.Next != null)
            {
                mergedNode.Next = minNode.Next.Next;
                minNode.Next.Next.Prev = mergedNode;
            }
            else
            {
                tail = mergedNode;
            }
            
            operations++;
        }
    }
}