//03.18.2026

/*
~ ProductOfArrayExceptSelf ~
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //initializing the first prefix product as 1 since no prefix
        int [] PreProduct = new int[nums.Length];
        
        //Prefix Product Calculation
        for(int i=0; i< nums.Length; i++){
            if(i == 0){
                //Base case for the very first prefix
                PreProduct[i] = 1;
            }else{
                PreProduct[i] = PreProduct[i-1]*nums[i-1];
            }
        }

        //Postfix Product Calculation
        int ProductBefore = 1;
        for(int i=0; i<nums.Length; i++){
            if(i==0){
                continue;
            }else{
                int length = nums.Length;
                ProductBefore=ProductBefore*nums[length-i];
            }  
            PreProduct[nums.Length-1-i] *= ProductBefore;
        }

        return PreProduct;
    }
}