public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;

        long number = x / 2;
        
        while (true) {
            long nextNumber = (number + x / number) / 2;
            if (nextNumber >= number) {
                return (int)number;
            }
            number = nextNumber;
        }
    }
}