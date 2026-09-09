class Solution:
    def intersection(self, nums1: List[int], nums2: List[int]) -> List[int]:
        myset = set(nums1)
        myset2 = set(nums2)
        arr = list(myset2.intersection(myset))
        return arr
