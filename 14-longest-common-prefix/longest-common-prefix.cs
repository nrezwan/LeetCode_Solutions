public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0)
            return "";
        string prefix = strs[0];

        for (int i = 0; i<prefix.Length; i++){
            char curChar = prefix[i];
            for (int j=1; j<strs.Length; j++){
                if(i >= strs[j].Length || strs[j][i] != curChar)
                {
                    return prefix.Substring(0, i);
                }
            }
        }
        
        return prefix;
    }
}