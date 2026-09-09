class Solution:
    def intersection(self, nums1: List[int], nums2: List[int]) -> List[int]:
        myset = set(nums1)
        myset2 = set()
        for i in range(len(nums2)):
            if nums2[i] in myset:
                myset2.add(nums2[i])
        arr = list(myset2)
        return arr
