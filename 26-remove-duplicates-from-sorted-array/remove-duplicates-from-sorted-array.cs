public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) 
            return 0;

        int insertPos = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[insertPos - 1]) {
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }
        
        return insertPos;
    }
}