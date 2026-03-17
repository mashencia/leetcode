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