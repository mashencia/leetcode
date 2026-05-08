public class Solution {
    public bool IsPalindrome(int x) {
        string text = x.ToString();
        int length = text.Length;
        for(int i = 0; (i < length/2); i++){
            if(text[i] != text[length - i - 1]){
                return false;
            }
        }
        return true;
    }
}