// 03.19.2026

/*
~ Longest Substring Without Repeating Characters ~
Time Complexity: O(n)
Space Complexity: O(n)
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int CurrentStart = 0;
        int MaximumLength = 0;

        var Dupes = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){

            //add the character seen to the hashmap with index or update
            char ch = s[i];
            
            if(Dupes.ContainsKey(ch) && Dupes[ch]>=CurrentStart){
                CurrentStart = Dupes[ch]+1;
                Dupes[ch] = i;
                continue;
            }else{
                Dupes[ch] = i;
                if(i - CurrentStart + 1>MaximumLength){
                    MaximumLength = i - CurrentStart + 1;
                }
            }
        }
        return MaximumLength;
    }
}

/*
Solved in linear time using a hashmap Dupes tracking when a character was last time seen in the string.
Current start tracks the position at which the potential shortest substring can start. Once a duplicate 
is encountered, the current start position moves to the postion one above the original position of the 
duplicate element. The maximum length is calculated by determining the position between the current index 
and the current start position. The maximum length is established if it is greater than the one previously
recorded.
*/