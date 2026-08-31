class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        results = s.split()
        return len(results[-1])