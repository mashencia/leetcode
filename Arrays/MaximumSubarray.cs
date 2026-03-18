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
            if(current < 0){
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
Solved in linear time iterating once through the array tracking the current and maximum sum.
If addition of the current element to the current sum indicated that the sum was negative,
the current sum was reset from 0. At iterations where addition of an element resulted in the
highest sum, the sum was recorder/updated as maximum.
*/
