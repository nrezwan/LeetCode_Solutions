class Solution:
    def isPerfectSquare(self, num: int) -> bool:
        if num < 0:
            return False
        if num == 0 or num == 1:
            return True
                    
        low = 1
        high = num // 2
        
        while low <= high:
            mid = (low + high) // 2 
            square = mid * mid
            
            if square == num:
                return True
            elif square < num:
                low = mid + 1
            else:
                high = mid - 1
        
        return False