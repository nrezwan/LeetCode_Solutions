public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        List<int> list = new List<int>(nums);
        int operations = 0;
        
        while (true)
        {
            bool isSorted = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            
            if (isSorted || list.Count <= 1)
                return operations;
            
            int minSum = int.MaxValue;
            int minIndex = 0;
            
            for (int i = 0; i < list.Count - 1; i++)
            {
                int currentSum = list[i] + list[i + 1];
                if (currentSum < minSum)
                {
                    minSum = currentSum;
                    minIndex = i;
                }
            }
            
            list[minIndex] = minSum;
            list.RemoveAt(minIndex + 1);
            operations++;
        }
    }
}