class Solution:
    def fib(self, n: int) -> int:
        memo = {}      
        def helper(x):
            if x in memo:
                return memo[x]
            if x <= 1:
                return x
            memo[x] = helper(x-1) + helper(x-2)
            return memo[x]
        
        return helper(n)
        