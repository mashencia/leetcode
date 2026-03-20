//03.17.2026

/*
~ Group Anagrams ~
Time Complexity: O(knlog(k))
Space Complexity:O(kn)
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var AnagramsDictionary = new Dictionary<string, IList<string>>();
        foreach(string str in strs){
            string key = String.Concat(str.OrderBy(c => c));
            AnagramsDictionary[key] = AnagramsDictionary.GetValueOrDefault(key, new List<string>());
            AnagramsDictionary[key].Add(str);
            
        }
        return AnagramsDictionary.Values.ToList();
    }   
}

/*
Solved using a Dictionary <key: alphabetically sorted string, value: list of anagrams>. The sorted string was 
added as a key only once, if other strings (anagrams) of the key exist then they would be added as values.
At the return, the values of the Dictionary are converted into a List and returned.
*/