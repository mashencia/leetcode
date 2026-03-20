// 03. 16. 2026

/*
~Two Sum~
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> ht = new();
        for(int i=0; i<nums.Length; i++){
            if(ht.ContainsKey(nums[i])){
                int key = nums[i];
                return new int[] {ht[key],i};
            }
            ht[target-nums[i]]= i;
        }
        return new int[] {-1,-1};
    }
}

/*
Solved using a Dictionary (hashmap) by mapping complements (target-num[i])
and their indecies. At each iteration, the nums[i] is looked for in the existing 
keys, then it signifies that there exists a complement that would add up to a 
target, hence, return the pair of indecies. If not, then the complement of the 
current nums[i] is to be added to the map. After the completion of the loop, invalid
indecies returned to signify that the pair of nums adding to the target does not exist.
*/