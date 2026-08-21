public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        
        string str = x.ToString();
        string reversed = new string(str.Reverse().ToArray());
        return str == reversed;
    }
}