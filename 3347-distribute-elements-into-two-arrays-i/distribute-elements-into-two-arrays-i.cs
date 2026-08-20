public class Solution {
    public int[] ResultArray(int[] nums)
    {
        if (nums.Length == 0) 
            return new int[0];
        if (nums.Length == 1) 
            return nums;

        int[] arr1 = new int[nums.Length];
        int[] arr2 = new int[nums.Length];
        int arr1Index = 0;
        int arr2Index = 0;

        arr1[arr1Index++] = nums[0];
        arr2[arr2Index++] = nums[1];

        for (int i = 2; i < nums.Length; i++)
        {
            if (arr1[arr1Index - 1] > arr2[arr2Index - 1])
                arr1[arr1Index++] = nums[i];
            else
                arr2[arr2Index++] = nums[i];
        }

        int[] result = new int[arr1Index + arr2Index];
        Array.Copy(arr1, 0, result, 0, arr1Index);
        Array.Copy(arr2, 0, result, arr1Index, arr2Index);
        
        return result;
    }
}