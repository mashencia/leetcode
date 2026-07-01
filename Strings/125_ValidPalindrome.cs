using System.Text.RegularExpressions; 

public class Solution {
    public bool IsPalindrome(string s) {
        string alphaString = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        string lowerStr = alphaString.ToLower();
        int length = alphaString.Length;

        for(int i = 0; i < length/2; i++){
            if(lowerStr[i] != lowerStr[length-i-1]){
                return false;
            }
        }

        return true;
    }
}
