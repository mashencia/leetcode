//03. 16. 2026
/*
~Contains Duplicates~
Time Complexity: O(n)
Space Complexity: O(n)
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach(int num in nums){
            if(!set.Add(num)){
                return true;
            }
        }
        return false;
    }
}

/*
Solved by using a set (HashSet). HashSet does not allow duplicate elements, hence, once a duplicate
is added, the .Add() method returns false. Therefore, when adding the elements, it was 
tracked whether .Add() returned false, and once did the ContainsDuplicate() method returned true. Otherwise,
.Add() had no issues adding elements, meaning no duplicates were encountered.
*/