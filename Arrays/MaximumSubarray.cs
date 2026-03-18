//03.18.2026
/*
Time Complexity: O(n)
Space Complexity: O(1)
*/
public class Solution {
    public int MaxSubArray(int[] nums) {
        int current = nums[0];
        int maximum = nums[0];
        for(int i = 1; i < nums.Length; i++){
            //Dipping sum
            if(current < 0 || maximum < 0){
                if(nums[i]>maximum){
                    maximum = nums[i];
                }
                current = 0;
            }
            current += nums[i];
            //Normal running (positive sum)
            if(current > maximum){
                maximum = current;
            }
            
        }
        return maximum;
    }
}

/*

*/
