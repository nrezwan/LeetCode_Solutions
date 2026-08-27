public class Solution {
    public bool IsValid(string s) {
        if(s == "") return true;
        if(s.Length == 1 || s == null) return false;

        var Stack = new Stack<char>();
        var i = 0;
        while(i<s.Length){
            char c = s[i];
            if(c == '(' || c == '[' || c == '{')
                Stack.Push(c);
            else {
                if (Stack.Count == 0) return false;
                char open = Stack.Pop();

                if (c == ')' && open != '(') return false;
                if (c == ']' && open != '[') return false;
                if (c == '}' && open != '{') return false;
            }
            i++;
        }
        
        if(Stack.Count==0)
            return true;
        else
            return false;
    }
}