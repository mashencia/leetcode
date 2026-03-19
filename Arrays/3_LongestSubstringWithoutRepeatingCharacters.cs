// 03.19.2026

/*
~ Longest Substring Without Repeating Characters ~
Time Complexity: O(n)
Space Complexity: O(1)
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int CurrentStart = 0;
        int CurrentLength  = 0;
        int MaximumLength = 0;

        var Dupes = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){

            //add the character seen to the hashmap with index or update
            char ch = s[i];
            
            if(Dupes.ContainsKey(ch) && Dupes[ch]>=CurrentStart){
                CurrentStart = Dupes[ch]+1;
                Dupes[ch] = i;
                CurrentLength = i - CurrentStart + 1;
                continue;
            }else{
                Dupes[ch] = i;
                if(++CurrentLength>MaximumLength){
                    MaximumLength = CurrentLength;
                }
            }
        }
        return MaximumLength;
    }
}