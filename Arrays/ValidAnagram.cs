// 03. 16. 2026
/*
~Valid Anagram~
Time Complexity: O(n)
Space Complexity: O(n)
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;

        var map = new Dictionary<char,int>();
        foreach(char ch in s){
            map[ch] = map.GetValueOrDefault(ch,0)+1;
        }
        foreach(char ch in t){
            if(!map.ContainsKey(ch) || (--map[ch])<0) return false;
        }
        return true;
    }
}

/*
Solved using a hashmap (Dictionary) allowing to track the frequency of characters
in the first string (s). The second string (t), was first compared by size (needs to match), 
then if the size matched, the frequency of characters were compared usign the created hashmap.
If a character encountered in string t was not in the map, then this violated the anagram conditions.
If the character was present in the hashmap, then the original frequency set by string s was decremented.
If the frequency decreased below 0, this signified that string t had a higher frequency for a certain
character, thus, character frequencies differed between the strings violating anagram conditions. Therefore, 
the method would return true only if the size of the array and frequencies of characters between
the strings s and t matched, otherwise, it would return false.
*/